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
    public class CreateOtherReceiveRequest : IRequest<CreateOtherReceiveResponse>
    {
        public string GetResourceMethod()
        {
            return "otherReceive/Create";
        }

        [JsonProperty("dto")]
        public RDRecordDTO OtherReceive { get; set; }
    }
}
