using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class RDRecordDTO : DTO
    {
        /// <summary>
        /// 外部系统数据编号
        /// </summary>
        [JsonProperty("ExternalCode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        [JsonProperty("Partner")]
        public PartnerDTO Partner { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [JsonProperty("Project")]
        public ProjectDTO Project { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        [JsonProperty("VoucherType")]
        public VoucherTypeDTO VoucherType { get; set; }

        /// <summary>
        /// 单据日期
        /// </summary>
        [JsonProperty("VoucherDate")]
        public string VoucherDate { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("BusiType")]
        public BusiTypeDTO BusiType { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty("Warehouse")]
        public WarehouseDTO Warehouse { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        [JsonProperty("Clerk")]
        public PersonDTO Clerk { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 单据明细
        /// </summary>
        [JsonProperty("RDRecordDetails")]
        public List<RDRecordDetailDTO> RDRecordDetails { get; set; }
    }
}
