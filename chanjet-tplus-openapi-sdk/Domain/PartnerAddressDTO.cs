using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    /// <summary>
    /// 联系方式
    /// </summary>
    public class PartnerAddressDTO : DTO
    {
        /// <summary>
        /// 到货地址
        /// </summary>
        [JsonProperty("ShipmentAddress")]
        public string ShipmentAddress { get; set; }

        /// <summary>
        /// 运输方式
        /// </summary>
        [JsonProperty("DeliveryMode")]
        public EnumItem DeliveryMode { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [JsonProperty("Position")]
        public string Position { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("Birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("TelephoneNo")]
        public string TelephoneNo { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        [JsonProperty("Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("EmailAddr")]
        public string EmailAddr { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        [JsonProperty("QqNo")]
        public string QqNo { get; set; }

        /// <summary>
        /// MSN
        /// </summary>
        [JsonProperty("MsnAddress")]
        public string MsnAddress { get; set; }

        /// <summary>
        /// UU
        /// </summary>
        [JsonProperty("UuNo")]
        public string UuNo { get; set; }

        /// <summary>
        /// 默认
        /// </summary>
        [JsonProperty("IsDefaultAddress")]
        public bool? IsDefaultAddress { get; set; }
    }
}
