using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response.Person;

namespace TPlus.Api.Request.Person
{
    public class CreatePersonRequest : TPlusRequest<CreatePersonResponse>
    {
        public override string GetResourceMethod()
        {
            return "person/Create";
        }

        [JsonProperty("dto")]
        public PersonDTO Person { get; set; }
    }
}
