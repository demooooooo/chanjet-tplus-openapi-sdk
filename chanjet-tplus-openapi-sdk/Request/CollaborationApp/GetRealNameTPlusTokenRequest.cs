using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Response.CollaborationApp;

namespace TPlus.Api.Request.CollaborationApp
{
    public class GetRealNameTPlusTokenRequest : IRequest<GetRealNameTPlusTokenResponse>
    {
        public string GetResourceMethod()
        {
            return "collaborationapp/GetRealNameTPlusToken?IsFree=1";
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
