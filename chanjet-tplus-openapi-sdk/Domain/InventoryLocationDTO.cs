using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class InventoryLocationDTO : DTO
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public decimal? Quantity { get; set; }
    }
}
