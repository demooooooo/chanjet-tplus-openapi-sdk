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
        private static VoucherTypeDTO otherDispatchVoucher;

        public static VoucherTypeDTO OtherDispatchVoucher
        {
            get
            {
                if (otherDispatchVoucher == null)
                {
                    otherDispatchVoucher = new VoucherTypeDTO { Code = "ST1024" };
                }

                return otherDispatchVoucher;
            }
        }
    }
}
