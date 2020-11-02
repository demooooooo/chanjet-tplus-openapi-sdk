using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Response
{
    public class NullResultResponse : TPlusResponse
    {
        public override void Load(string s)
        {
            if (s != "null")
            {
                base.Load(s);
            }
        }
    }
}
