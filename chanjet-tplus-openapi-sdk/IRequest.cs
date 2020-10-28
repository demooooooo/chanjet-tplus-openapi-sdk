using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api
{
    public interface IRequest<out T> where T : TPlusResponse
    {
        string GetResourceMethod();
    }
}
