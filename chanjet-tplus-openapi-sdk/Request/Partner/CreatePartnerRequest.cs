using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.Partner;

namespace TPlus.Api.Request.Partner
{
    public class CreatePartnerRequest : TPlusRequest<CreatePartnerResponse>
    {
        public override string GetResourceMethod()
        {
            return "partner/Create";
        }

        [JsonProperty("dto")]
        public PartnerDTO Partner { get; set; }
    }
}
