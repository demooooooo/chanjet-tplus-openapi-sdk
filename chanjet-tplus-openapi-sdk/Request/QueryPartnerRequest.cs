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
    public class QueryPartnerRequest : TPlusRequest<QueryPartnerResponse>
    {
        public override string GetResourceMethod()
        {
            return "partner/Query";
        }

        [JsonProperty("param")]
        public PartnerEntityDTO Param { get; set; }
    }
}
