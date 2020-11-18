using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class PartnerDTO : DTO
    {
        /// <summary>
        /// 简称
        /// </summary>
        [JsonProperty("PartnerAbbName")]
        public string PartnerAbbName { get; set; }

        /// <summary>
        /// 性质
        /// </summary>
        [JsonProperty("PartnerType")]
        public EnumItemEntityDTO PartnerType { get; set; }

        /// <summary>
        /// 结算客户
        /// </summary>
        [JsonProperty("SettlementPartner")]
        public PartnerDTO SettlementPartner { get; set; }

        /// <summary>
        /// 所属类别
        /// </summary>
        [JsonProperty("PartnerClass")]
        public PartnerClassDTO PartnerClass { get; set; }

        /// <summary>
        /// 助记码
        /// </summary>
        [JsonProperty("Shorthand")]
        public string Shorthand { get; set; }

        /// <summary>
        /// 分管部门
        /// </summary>
        [JsonProperty("SaleDepartment")]
        public DepartmentDTO SaleDepartment { get; set; }

        /// <summary>
        /// 分管人员
        /// </summary>
        [JsonProperty("SaleMan")]
        public PersonDTO SaleMan { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("District")]
        public DistrictDTO District { get; set; }

        /// <summary>
        /// 销售信用额度
        /// </summary>
        [JsonProperty("SaleCreditLine")]
        public decimal? SaleCreditLine { get; set; }

        /// <summary>
        /// 零售客户
        /// </summary>
        [JsonProperty("SellCustomer")]
        public bool? SellCustomer { get; set; }

        /// <summary>
        /// 跑店
        /// </summary>
        [JsonProperty("RunShop")]
        public bool? RunShop { get; set; }

        /// <summary>
        /// 停用
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 自动生成会员
        /// </summary>
        [JsonProperty("AutoCreateMember")]
        public bool? AutoCreateMember { get; set; }

        /// <summary>
        /// 会员类型
        /// </summary>
        [JsonProperty("MemberType")]
        public MemberTypeDTO MemberType { get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        [JsonProperty("Representative")]
        public string Representative { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [JsonProperty("Accbank")]
        public EnumItem Accbank { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("BankAccount")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 纳税号
        /// </summary>
        [JsonProperty("TaxRegcode")]
        public string TaxRegcode { get; set; }

        /// <summary>
        /// 客户地址电话
        /// </summary>
        [JsonProperty("CustomerAddressPhone")]
        public string CustomerAddressPhone { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public EnumItem TaxRate { get; set; }

        /// <summary>
        /// 客户价格等级
        /// </summary>
        [JsonProperty("PriceGrade")]
        public EnumItem PriceGrade { get; set; }

        /// <summary>
        /// 采购报价含税
        /// </summary>
        [JsonProperty("IsContainTaxOnPurchase")]
        public bool? IsContainTaxOnPurchase { get; set; }

        /// <summary>
        /// 默认收款方式
        /// </summary>
        [JsonProperty("SaleSettleStyle")]
        public EnumItem SaleSettleStyle { get; set; }

        /// <summary>
        /// 默认付款方式
        /// </summary>
        [JsonProperty("PurchaseSettleStyle")]
        public EnumItem PurchaseSettleStyle { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("PartnerAddresDTOs")]
        public IList<PartnerAddressDTO> PartnerAddressDTOs { get; set; }
    }
}
