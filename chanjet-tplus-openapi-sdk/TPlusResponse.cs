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
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public string Body { get; set; }

        public virtual bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(Code);
            }
        }

        public virtual void Load(string s)
        {
            JsonConvert.PopulateObject(s, this);
        }
    }
}
