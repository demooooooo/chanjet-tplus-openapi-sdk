using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.JsonConverters
{
    public class TPlusDateConverter : IsoDateTimeConverter
    {
        public TPlusDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
