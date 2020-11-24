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
        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty("Warehouse")]
        public WarehouseDTO Warehouse { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [JsonProperty("Project")]
        public ProjectDTO Project { get; set; }

        /// <summary>
        /// 存货
        /// </summary>
        [JsonProperty("Inventory")]
        public InventoryDTO Inventory { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        [JsonProperty("InventoryBarCode")]
        public string InventoryBarCode { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonProperty("Unit")]
        public UnitDTO Unit { get; set; }

        /// <summary>
        /// 计量单位2
        /// </summary>
        [JsonProperty("Unit2")]
        public UnitDTO Unit2 { get; set; }

        /// <summary>
        /// 换算率
        /// </summary>
        [JsonProperty("UnitExchangeRate")]
        public decimal? UnitExchangeRate { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty("Batch")]
        public string Batch { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// 报价
        /// </summary>
        [JsonProperty("OrigPrice")]
        public decimal? OrigPrice { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [JsonProperty("DiscountRate")]
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// 原币单价
        /// </summary>
        [JsonProperty("OrigDiscountPrice")]
        public decimal? OrigDiscountPrice { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// 原币含税单价
        /// </summary>
        [JsonProperty("OrigTaxPrice")]
        public decimal? OrigTaxPrice { get; set; }

        /// <summary>
        /// 原币金额
        /// </summary>
        [JsonProperty("OrigDiscountAmount")]
        public decimal? OrigDiscountAmount { get; set; }

        /// <summary>
        /// 原币税额
        /// </summary>
        [JsonProperty("OrigTax")]
        public decimal? OrigTax { get; set; }

        /// <summary>
        /// 原币含税金额
        /// </summary>
        [JsonProperty("OrigTaxAmount")]
        public decimal? OrigTaxAmount { get; set; }

        /// <summary>
        /// 原币折扣额
        /// </summary>
        [JsonProperty("OrigDiscount")]
        public decimal? OrigDiscount { get; set; }

        /// <summary>
        /// 入库单号
        /// </summary>
        [JsonProperty("ReceiveVoucherCode")]
        public string ReceiveVoucherCode { get; set; }

        /// <summary>
        /// 赠品
        /// </summary>
        [JsonProperty("IsPresent")]
        public bool? IsPresent { get; set; }

        /// <summary>
        /// 交货日期
        /// </summary>
        [JsonProperty("DeliveryDate")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 手工确定成本
        /// </summary>
        [JsonProperty("IsManualCost")]
        public bool? IsManualCost { get; set; }

        /// <summary>
        /// 成本金额
        /// </summary>
        [JsonProperty("CostAmount")]
        public decimal? CostAmount { get; set; }

        /// <summary>
        /// 成本价
        /// </summary>
        [JsonProperty("CostPrice")]
        public decimal? CostPrice { get; set; }

        /// <summary>
        /// 货位
        /// </summary>
        [JsonProperty("InventoryLocations")]
        public IList<InventoryLocationDTO> InventoryLocations { get; set; }
    }
}
