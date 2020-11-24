using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class SaleDeliverySettlementDTO : DTO
    {
        /// <summary>
        /// 收款金额
        /// </summary>
        [JsonProperty("OrigAmount")]
        public decimal? OrigAmount { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        [JsonProperty("SettleStyle")]
        public SettleStyleDTO SettleStyle { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("BankAccount")]
        public BankAccountDTO BankAccount { get; set; }
    }
}
