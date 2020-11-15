using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class BaseEntityDTO : DTO
    {
        /// <summary>
        /// 返回字段
        /// </summary>
        [JsonProperty("SelectFields")]
        public string SelectFields { get; set; }
    }
}
