using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.SaleDelivery;

namespace TPlus.Api.Request.SaleDelivery
{
    public class CreateSaleDeliveryRequest : TPlusRequest<CreateSaleDeliveryResponse>
    {
        public override string GetResourceMethod()
        {
            return "saleDelivery/Create";
        }

        [JsonProperty("dto")]
        public SaleDeliveryDTO SaleDelivery { get; set; }
    }
}
