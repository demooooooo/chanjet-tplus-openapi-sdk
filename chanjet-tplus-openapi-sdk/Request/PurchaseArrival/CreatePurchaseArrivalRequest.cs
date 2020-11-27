using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.PurchaseArrival;

namespace TPlus.Api.Request.PurchaseArrival
{
    public class CreatePurchaseArrivalRequest : TPlusRequest<CreatePurchaseArrivalResponse>
    {
        public override string GetResourceMethod()
        {
            return "purchaseArrival/Create";
        }

        [JsonProperty("dto")]
        public PurchaseArrivalDTO PurchaseArrival { get; set; }
    }
}
