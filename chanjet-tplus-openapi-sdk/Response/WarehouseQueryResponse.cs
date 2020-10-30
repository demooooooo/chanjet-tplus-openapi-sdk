using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;

namespace TPlus.Api.Response
{
    public class WarehouseQueryResponse : TPlusResponse
    {
        public List<WarehouseDTO> Result { get; set; }

        public override void Load(string s)
        {
            if (s.StartsWith("[") && s.EndsWith("]"))
            {
                Result = JsonConvert.DeserializeObject<List<WarehouseDTO>>(s);
            }
            else
            {
                base.Load(s);
            }
        }
    }
}
