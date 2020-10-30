using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class WarehouseEntityDTO : DTO
    {
        [JsonProperty("Selectfields")]
        public string SelectFields { get; set; }
    }
}
