using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.OtherReceive;

namespace TPlus.Api.Request.OtherReceive
{
    public class CreateOtherReceiveRequest : TPlusRequest<CreateOtherReceiveResponse>
    {
        public override string GetResourceMethod()
        {
            return "otherReceive/Create";
        }

        [JsonProperty("dto")]
        public RDRecordDTO OtherReceive { get; set; }
    }
}
