using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class SaleDeliveryDTO : DTO
    {
        /// <summary>
        /// 单据日期
        /// </summary>
        [JsonProperty("VoucherDate")]
        public string VoucherDate { get; set; }

        /// <summary>
        /// 外部系统单据编号
        /// </summary>
        [JsonProperty("ExternalCode")]
        public string ExternalCode { get; set; }

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
        /// 客户
        /// </summary>
        [JsonProperty("Customer")]
        public PartnerDTO Customer { get; set; }

        /// <summary>
        /// 结算客户
        /// </summary>
        [JsonProperty("SettleCustomer")]
        public PartnerDTO SettleCustomer { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty("Warehouse")]
        public WarehouseDTO Warehouse { get; set; }

        /// <summary>
        /// 出库类别
        /// </summary>
        [JsonProperty("RdStyle")]
        public RdStyleDTO RdStyle { get; set; }

        /// <summary>
        /// 自动生成销售出库单
        /// </summary>
        [JsonProperty("IsAutoGenerateSaleOut")]
        public bool? IsAutoGenerateSaleOut { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [JsonProperty("Department")]
        public DepartmentDTO Department { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        [JsonProperty("Clerk")]
        public PersonDTO Clerk { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [JsonProperty("Project")]
        public ProjectDTO Project { get; set; }

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
        /// 交货日期
        /// </summary>
        [JsonProperty("DeliveryDate")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 运输方式
        /// </summary>
        [JsonProperty("DeliveryMode")]
        public EnumItem DeliveryMode { get; set; }

        /// <summary>
        /// 收款方式
        /// </summary>
        [JsonProperty("ReciveType")]
        public EnumItem ReceiveType { get; set; }

        /// <summary>
        /// 收款到期日
        /// </summary>
        [JsonProperty("RecivingMaturity")]
        public string ReceivingMaturity { get; set; }

        /// <summary>
        /// 整单折扣率
        /// </summary>
        [JsonProperty("DiscountRate")]
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// 现结金额
        /// </summary>
        [JsonProperty("OrigSettleAmount")]
        public decimal? OrigSettleAmount { get; set; }

        /// <summary>
        /// 抹零金额
        /// </summary>
        [JsonProperty("OrigAllowances")]
        public decimal? OrigAllowances { get; set; }

        /// <summary>
        /// 价格跟踪
        /// </summary>
        [JsonProperty("IsPriceTrace")]
        public bool? IsPriceTrace { get; set; }

        /// <summary>
        /// 自动生成发票
        /// </summary>
        [JsonProperty("IsAutoGenerateInvoice")]
        public bool? IsAutoGenerateInvoice { get; set; }

        /// <summary>
        /// 按仓库拆单出库
        /// </summary>
        [JsonProperty("IsSeparateByWareHouse")]
        public bool? IsSeparateByWareHouse { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        [JsonProperty("Member")]
        public MemberDTO Member { get; set; }

        /// <summary>
        /// 送货地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("LinkMan")]
        public string LinkMan { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 制单人
        /// </summary>
        [JsonProperty("Maker")]
        public string Maker { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 现结明细
        /// </summary>
        [JsonProperty("SaleDeliverySettlements")]
        public IList<SaleDeliverySettlementDTO> SaleDeliverySettlements { get; set; }

        /// <summary>
        /// 单据明细
        /// </summary>
        [JsonProperty("SaleDeliveryDetails")]
        public IList<SaleDeliveryDetailDTO> SaleDeliveryDetails { get; set; }
    }
}
