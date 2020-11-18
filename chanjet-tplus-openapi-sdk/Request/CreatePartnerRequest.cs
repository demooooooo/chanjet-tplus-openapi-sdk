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
    public class CreatePartnerRequest : IRequest<CreatePartnerResponse>
    {
        public string GetResourceMethod()
        {
            return "partner/Create";
        }

        [JsonProperty("dto")]
        public PartnerDTO Partner { get; set; }
    }
}
