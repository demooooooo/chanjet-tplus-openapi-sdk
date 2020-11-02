using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Response
{
    public class ListResultResponse<T> : TPlusResponse
    {
        public List<T> Result { get; set; }

        public override void Load(string s)
        {
            if (s.StartsWith("[") && s.EndsWith("]"))
            {
                Result = JsonConvert.DeserializeObject<List<T>>(s);
            }
            else
            {
                base.Load(s);
            }
        }
    }
}
