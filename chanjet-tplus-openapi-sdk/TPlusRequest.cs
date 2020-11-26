using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api
{
    public abstract class TPlusRequest<T> where T : TPlusResponse
    {
        public abstract string GetResourceMethod();

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
