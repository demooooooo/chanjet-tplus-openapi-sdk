using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Response.CollaborationApp
{
    public class GetRealNameTPlusTokenResponse : TPlusResponse
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}
