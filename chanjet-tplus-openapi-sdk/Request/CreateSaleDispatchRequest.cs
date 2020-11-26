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
    public class CreateSaleDispatchRequest : TPlusRequest<CreateSaleDispatchResponse>
    {
        public override string GetResourceMethod()
        {
            return "saleDispatch/Create";
        }

        [JsonProperty("dto")]
        public RDRecordDTO SaleDispatch { get; set; }
    }
}
