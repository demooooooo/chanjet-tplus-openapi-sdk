using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class PartnerEntityDTO : BaseEntityDTO
    {
        /// <summary>
        /// 助记码
        /// </summary>
        [JsonProperty("Shorthand")]
        public string Shorthand { get; set; }

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
        /// 所属类别
        /// </summary>
        [JsonProperty("PartnerClass")]
        public PartnerClassDTO PartnerClass { get; set; }

        /// <summary>
        /// 结算客户
        /// </summary>
        [JsonProperty("SettlementPartner")]
        public PartnerDTO SettlementPartner { get; set; }

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
        /// 客户等级价格
        /// </summary>
        [JsonProperty("PriceGrade")]
        public EnumItemEntityDTO PriceGrade { get; set; }

        /// <summary>
        /// 停用
        /// </summary>
        [JsonProperty("Disabled")]
        public string Disabled { get; set; }

        /// <summary>
        /// 信用额度
        /// </summary>
        [JsonProperty("CreditBalance")]
        public string CreditBalance { get; set; }

        /// <summary>
        /// 应收余额
        /// </summary>
        [JsonProperty("ARBalance")]
        public string ARBalance { get; set; }

        /// <summary>
        /// 预收余额
        /// </summary>
        [JsonProperty("AdvRBalance")]
        public string AdvRBalance { get; set; }

        /// <summary>
        /// 应付余额
        /// </summary>
        [JsonProperty("APBalance")]
        public string APBalance { get; set; }

        /// <summary>
        /// 预付余额
        /// </summary>
        [JsonProperty("AdvPBalance")]
        public string AdvPBalance { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("PartnerAddress")]
        public PartnerAddressDTO PartnerAddress { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("PartnerAddresDTOs")]
        public IList<PartnerAddressDTO> PartnerAddressDTOs { get; set; }

        public string PageSize { get; set; }

        public bool OnlyHasAuthData { get; set; }
    }
}
