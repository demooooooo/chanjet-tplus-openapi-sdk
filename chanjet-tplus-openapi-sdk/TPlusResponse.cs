using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api
{
    public abstract class TPlusResponse
    {
        [JsonProperty("code")]
        public string ErrCode { get; set; }

        [JsonProperty("message")]
        public string ErrMsg { get; set; }

        public string Body { get; set; }

        public bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(ErrCode);
            }
        }
    }
}
