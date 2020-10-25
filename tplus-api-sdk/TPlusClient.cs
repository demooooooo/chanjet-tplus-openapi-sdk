using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Util;

namespace TPlus.Api
{
    public class TPlusClient
    {
        private static readonly HttpClient httpClient;

        static TPlusClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        private readonly string serverUrl;
        private readonly string appKey;
        private readonly string appSecret;
        private readonly string privateKeyPath;

        public TPlusClient(string serverUrl, string appKey, string appSecret, string privateKeyPath)
        {
            this.serverUrl = serverUrl;
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.privateKeyPath = privateKeyPath;
        }

        private T Parse<T>(string body) where T : TPlusResponse
        {
            T rsp = JsonConvert.DeserializeObject<T>(body);

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }

        private T DoExecute<T>(IRequest<T> request, string access_token) where T : TPlusResponse
        {
            string args = JsonConvert.SerializeObject(request, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            string authorization = SecurityUtil.CreateAuthorizationHeader(appKey, appSecret, "", privateKeyPath, access_token);

            var payload = new Dictionary<string, string>
            {
                { "_args", args },
            };

            string requestUri = serverUrl + request.GetResourceMethod();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
            requestMessage.Headers.TryAddWithoutValidation("Authorization", authorization);
            requestMessage.Content = new FormUrlEncodedContent(payload);

            HttpResponseMessage responseMessage = httpClient.SendAsync(requestMessage).Result;
            string body = responseMessage.Content.ReadAsStringAsync().Result;
            return Parse<T>(body);
        }

        public T Execute<T>(IRequest<T> request) where T : TPlusResponse
        {
            return DoExecute<T>(request, null);
        }

        public T Execute<T>(IRequest<T> request, string access_token) where T : TPlusResponse
        {
            return DoExecute<T>(request, access_token);
        }
    }
}
