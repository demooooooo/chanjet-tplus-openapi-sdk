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
        [JsonProperty("VoucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("Warehouse")]
        public WarehouseDTO Warehouse { get; set; }

        [JsonProperty("Project")]
        public ProjectDTO Project { get; set; }

        [JsonProperty("ExternalCode")]
        public string ExternalCode { get; set; }

        [JsonProperty("Customer")]
        public PartnerDTO Customer { get; set; }

        [JsonProperty("InvoiceType")]
        public EnumItem InvoiceType { get; set; }

        [JsonProperty("Memo")]
        public string Memo { get; set; }

        [JsonProperty("SaleDeliveryDetails")]
        public List<SaleDeliveryDetailDTO> SaleDeliveryDetails { get; set; }
    }
}
