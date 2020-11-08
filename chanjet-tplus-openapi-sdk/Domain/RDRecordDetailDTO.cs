using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class RDRecordDetailDTO : DTO
    {
        /// <summary>
        /// 存货
        /// </summary>
        [JsonProperty("Inventory")]
        public InventoryDTO Inventory { get; set; }

        /// <summary>
        /// 主计量单位数量
        /// </summary>
        [JsonProperty("BaseQuantity")]
        public decimal? BaseQuantity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("Price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// 手工确定成本
        /// </summary>
        [JsonProperty("IsManualCost")]
        public bool? IsManualCost { get; set; }
    }
}
