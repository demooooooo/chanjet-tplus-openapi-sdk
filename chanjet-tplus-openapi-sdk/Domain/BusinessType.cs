using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    /// <summary>
    /// 业务类型
    /// 对应AA_BusiType表
    /// 注意，当前业务类型列表并不完整。
    /// 大家可自行添加通用的业务类型，但不要把自定义的业务类型添加到SDK中。
    /// </summary>
    public class BusinessType
    {
        public static BusiTypeDTO EnumItemByCode(string code)
        {
            return new BusiTypeDTO { Code = code };
        }

        public static BusiTypeDTO 其他 => EnumItemByCode("13");
        public static BusiTypeDTO 其他退库 => EnumItemByCode("14");
        public static BusiTypeDTO 普通销售 => EnumItemByCode("15");
        public static BusiTypeDTO 销售退货 => EnumItemByCode("16");
        public static BusiTypeDTO 盘亏 => EnumItemByCode("25");
    }
}
