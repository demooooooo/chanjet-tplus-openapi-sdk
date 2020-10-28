using Jose;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Util
{
    public class SecurityUtil
    {
        /// <summary>
        /// 签名方式1
        /// </summary>
        /// <param name="data">签名内容的json串格式</param>
        /// <param name="pemFile">私钥文件物理路径</param>
        /// <returns></returns>
        public static string CreateSignedToken(string data, string pemFile)
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //5分钟内有效
            var exp = ts.TotalMilliseconds + 30000;

            var payload = new Dictionary<string, object>
            {
                { "sub", "tester" },
                { "exp", exp },
                { "datas", GetMd5(data) }
            };

            using (StreamReader reader = File.OpenText(pemFile))
            {
                PemReader pemReader = new PemReader(reader);
                AsymmetricCipherKeyPair keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
                RSA privateKey = DotNetUtilities.ToRSA((RsaPrivateCrtKeyParameters)keyPair.Private);
                return JWT.Encode(payload, privateKey, JwsAlgorithm.PS256);
            }
        }

        /// <summary>
        /// 签名方式2
        /// </summary>
        /// <param name="data">签名内容的json串格式</param>
        /// <param name="pemFile">私钥文件物理路径</param>
        /// <param name="customParams">签名附加内容</param>
        /// <returns></returns>
        public static string CreateSignedToken(string data, string pemFile, IDictionary<string, object> customParams)
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //5分钟内有效
            var exp = ts.TotalMilliseconds + 30000;

            var payload = new Dictionary<string, object>
            {
                { "sub", "chanjet" },
                { "exp", exp },
                { "datas", GetMd5(data) }
            };

            foreach (var param in customParams)
            {
                payload.Add(param.Key, param.Value);
            }

            using (StreamReader reader = File.OpenText(pemFile))
            {
                PemReader pemReader = new PemReader(reader);
                AsymmetricCipherKeyPair keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
                RSA privateKey = DotNetUtilities.ToRSA((RsaPrivateCrtKeyParameters)keyPair.Private);
                return JWT.Encode(payload, privateKey, JwsAlgorithm.PS256);
            }
        }

        /// <summary>
        /// 获取md5值
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMd5(string s)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(s));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        /// <summary>
        /// 生成Authorization头，根据access_token传值与否，判断是认证还是业务调用
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="appSecret"></param>
        /// <param name="orgId"></param>
        /// <param name="pemFile">私钥文件物理路径</param>
        /// <param name="access_token">业务调用需要传入access_token值</param>
        /// <returns></returns>
        public static string CreateAuthorizationHeader(string appKey, string appSecret, string orgId, string pemFile, string access_token)
        {
            Dictionary<string, object> appInfo = new Dictionary<string, object>
            {
                { "appkey", appKey },
                { "orgid", orgId },
                { "appsecret", appSecret }
            };
            string data = JsonConvert.SerializeObject(appInfo);

            string authInfo;
            if (string.IsNullOrWhiteSpace(access_token))
            {
                // 认证使用【签名方式1】
                authInfo = CreateSignedToken(data, pemFile);
            }
            else
            {
                Dictionary<string, object> customParams = new Dictionary<string, object>
                {
                    { "access_token", access_token }
                };

                // 业务调用使用【签名方式2】
                authInfo = CreateSignedToken(data, pemFile, customParams);
            }

            Dictionary<string, object> auth = new Dictionary<string, object>
            {
                { "appKey", appKey },
                { "authInfo", authInfo },
                { "orgId", orgId }
            };
            string authStr = JsonConvert.SerializeObject(auth);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(authStr));
        }
    }
}
