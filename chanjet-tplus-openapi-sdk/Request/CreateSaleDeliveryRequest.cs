using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response;

namespace TPlus.Api.Request
{
    public class CreateSaleDeliveryRequest : IRequest<CreateSaleDeliveryResponse>
    {
        public string GetResourceMethod()
        {
            return "saleDelivery/Create";
        }

        [JsonProperty("dto")]
        public SaleDeliveryDTO SaleDelivery { get; set; }
    }
}
