using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.JsonConverters;

namespace TPlus.Api.Domain
{
    public class PurchaseArrivalDTO : DTO
    {
        /// <summary>
        /// 外部系统单据编号
        /// </summary>
        [JsonProperty("ExternalCode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// 单据日期
        /// </summary>
        [JsonProperty("VoucherDate")]
        [JsonConverter(typeof(TPlusDateConverter))]
        public DateTime? VoucherDate { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("BusinessType")]
        public BusiTypeDTO BusinessType { get; set; }

        /// <summary>
        /// 票据类型
        /// </summary>
        [JsonProperty("InvoiceType")]
        public EnumItem InvoiceType { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        [JsonProperty("PayType")]
        public EnumItem PayType { get; set; }

        /// <summary>
        /// 往来单位（供应商）
        /// </summary>
        [JsonProperty("Partner")]
        public PartnerDTO Partner { get; set; }

        /// <summary>
        /// 出库类别
        /// </summary>
        [JsonProperty("RdStyle")]
        public RdStyleDTO RdStyle { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty("Warehouse")]
        public WarehouseDTO Warehouse { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [JsonProperty("Department")]
        public DepartmentDTO Department { get; set; }

        /// <summary>
        /// 经手人
        /// </summary>
        [JsonProperty("Clerk")]
        public PersonDTO Clerk { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("Currency")]
        public CurrencyDTO Currency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonProperty("ExchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// 单据明细
        /// </summary>
        [JsonProperty("VoucherDetails")]
        public IList<PurchaseArrivalDetailDTO> VoucherDetails { get; set; }

        /// <summary>
        /// 现结金额明细
        /// </summary>
        [JsonProperty("ArrivalMultiSettleDetails")]
        public IList<PurchaseArrivalMultiSettleDetailDTO> ArrivalMultiSettleDetails { get; set; }
    }
}
