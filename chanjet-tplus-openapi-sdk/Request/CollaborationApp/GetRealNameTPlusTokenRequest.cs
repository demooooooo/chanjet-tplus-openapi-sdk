using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Response.CollaborationApp;
using TPlus.Api.Util;

namespace TPlus.Api.Request.CollaborationApp
{
    public class GetRealNameTPlusTokenRequest : TPlusRequest<GetRealNameTPlusTokenResponse>
    {
        public override string GetResourceMethod()
        {
            return "collaborationapp/GetRealNameTPlusToken?IsFree=1";
        }

        public override string ToJson()
        {
            GetRealNameTPlusTokenRequest request = (GetRealNameTPlusTokenRequest)this.MemberwiseClone();
            if (!string.IsNullOrEmpty(request.Password))
            {
                request.Password = SecurityUtil.GetMd5(request.Password);
            }

            return JsonConvert.SerializeObject(request, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("accNum")]
        public string AccNum { get; set; }

        [JsonProperty("cspAppKey")]
        public string CspAppKey { get; set; }

        [JsonProperty("cspAppSecret")]
        public string CspAppSecret { get; set; }
    }
}
