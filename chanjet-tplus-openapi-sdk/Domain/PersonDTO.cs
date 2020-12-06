using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class PersonDTO : DTO
    {
        /// <summary>
        /// 出生日期
        /// </summary>
        [JsonProperty("Birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        [JsonProperty("Department")]
        public DepartmentDTO Department { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        [JsonProperty("IsSalesman")]
        public bool? IsSalesman { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("MobilePhoneNo")]
        public string MobilePhoneNo { get; set; }
    }
}
