using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Response;

namespace TPlus.Api.Request
{
    public class LoginRequest : IRequest<LoginResponse>
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
    }
}
