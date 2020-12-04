using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.JsonConverters;

namespace TPlus.Api.Domain
{
    public class PurchaseArrivalDetailDTO : DTO
    {
        /// <summary>
        /// 存货
        /// </summary>
        [JsonProperty("Inventory")]
        public InventoryDTO Inventory { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [JsonProperty("Project")]
        public ProjectDTO Project { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonProperty("ExpiryDate")]
        [JsonConverter(typeof(TPlusDateConverter))]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty("Batch")]
        public string Batch { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonProperty("Unit")]
        public UnitDTO Unit { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// 主计量单位数量
        /// </summary>
        [JsonProperty("BaseQuantity")]
        public decimal? BaseQuantity { get; set; }

        /// <summary>
        /// 成本金额
        /// </summary>
        [JsonProperty("Amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 成本单价
        /// </summary>
        [JsonProperty("Price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// 数量2
        /// </summary>
        [JsonProperty("Quantity2")]
        public decimal? Quantity2 { get; set; }

        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonProperty("OrigTaxAmount")]
        public decimal? OrigTaxAmount { get; set; }

        /// <summary>
        /// 含税单价
        /// </summary>
        [JsonProperty("OrigTaxPrice")]
        public decimal? OrigTaxPrice { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("OrigDiscountPrice")]
        public decimal? OrigDiscountPrice { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("OrigDiscountAmount")]
        public decimal? OrigDiscountAmount { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [JsonProperty("DiscountRate")]
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// 报价
        /// </summary>
        [JsonProperty("OrigPrice")]
        public decimal? OrigPrice { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public decimal? TaxRate { get; set; }
    }
}
