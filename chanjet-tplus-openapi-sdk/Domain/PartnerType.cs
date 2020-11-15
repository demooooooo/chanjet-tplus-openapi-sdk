using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class PartnerType
    {
        public static EnumItem EnumItemByCode(string code)
        {
            return new EnumItem { Code = code };
        }

        /// <summary>
        /// 供应商
        /// </summary>
        public static EnumItem Supplier => EnumItemByCode("00");

        /// <summary>
        /// 客户
        /// </summary>
        public static EnumItem Customer => EnumItemByCode("01");

        /// <summary>
        /// 客户/供应商
        /// </summary>
        public static EnumItem Partner => EnumItemByCode("02");
    }
}
