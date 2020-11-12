using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    /// <summary>
    /// 单据类型
    /// 对应SM_VoucherType表
    /// </summary>
    public class VoucherType
    {
        public static VoucherTypeDTO EnumItemByCode(string code)
        {
            return new VoucherTypeDTO { Code = code };
        }

        public static VoucherTypeDTO 其他入库单 => EnumItemByCode("ST1004");
        public static VoucherTypeDTO 销售出库单 => EnumItemByCode("ST1021");
        public static VoucherTypeDTO 其他出库单 => EnumItemByCode("ST1024");
    }
}
