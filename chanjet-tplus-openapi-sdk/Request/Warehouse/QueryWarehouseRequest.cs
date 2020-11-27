using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.Warehouse;

namespace TPlus.Api.Request.Warehouse
{
    public class QueryWarehouseRequest : TPlusRequest<QueryWarehouseResponse>
    {
        public override string GetResourceMethod()
        {
            return "warehouse/Query";
        }

        [JsonProperty("param")]
        public WarehouseEntityDTO Param { get; set; }
    }
}
