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
    public class CreatePurchaseArrivalRequest : IRequest<CreatePurchaseArrivalResponse>
    {
        public string GetResourceMethod()
        {
            return "purchaseArrival/Create";
        }

        [JsonProperty("dto")]
        public PurchaseArrivalDTO PurchaseArrival { get; set; }
    }
}
