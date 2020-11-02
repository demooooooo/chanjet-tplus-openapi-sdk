using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class SaleDeliveryDetailDTO : DTO
    {
        [JsonProperty("Inventory")]
        public InventoryDTO Inventory { get; set; }

        [JsonProperty("Unit")]
        public UnitDTO Unit { get; set; }

        [JsonProperty("Quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("TaxRate")]
        public decimal? TaxRate { get; set; }

        [JsonProperty("OrigDiscountAmount")]
        public decimal? OrigDiscountAmount { get; set; }

        /// <summary>
        /// 原币含税金额
        /// </summary>
        [JsonProperty("OrigTaxAmount")]
        public decimal? OrigTaxAmount { get; set; }
    }
}
