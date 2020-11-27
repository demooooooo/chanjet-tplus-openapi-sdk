using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.OtherDispatch;

namespace TPlus.Api.Request.OtherDispatch
{
    public class CreateOtherDispatchRequest : TPlusRequest<CreateOtherDispatchResponse>
    {
        public override string GetResourceMethod()
        {
            return "otherDispatch/Create";
        }

        [JsonProperty("dto")]
        public RDRecordDTO OtherDispatch { get; set; }
    }
}
