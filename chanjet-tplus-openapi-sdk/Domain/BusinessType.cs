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
    /// TODO: 因为是账套相关的设置，建议从SDK移除。
    /// </summary>
    public class BusinessType
    {
        private static BusiTypeDTO other;

        public static BusiTypeDTO Other
        {
            get
            {
                if (other == null)
                {
                    other = new BusiTypeDTO { Code = "13" };
                }

                return other;
            }
        }
    }
}
