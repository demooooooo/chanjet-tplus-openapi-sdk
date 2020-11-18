using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Response
{
    public class StringResultResponse : TPlusResponse
    {
        public string Result { get; set; }

        public override void Load(string s)
        {
            if (s.StartsWith("\"") && s.EndsWith("\""))
            {
                Result = s.Substring(1, s.Length - 2);
            }
            else
            {
                base.Load(s);
            }
        }
    }
}
