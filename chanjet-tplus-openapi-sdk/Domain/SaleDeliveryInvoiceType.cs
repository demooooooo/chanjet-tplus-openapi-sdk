using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlus.Api.Domain
{
    public class SaleDeliveryInvoiceType
    {
        /// <summary>
        /// 普通发票
        /// </summary>
        public static EnumItem CommonInvoice
        {
            get
            {
                return new EnumItem { Code = "00" };
            }
        }

        /// <summary>
        /// 专用发票
        /// </summary>
        public static EnumItem SpecialInvioce
        {
            get
            {
                return new EnumItem { Code = "01" };
            }
        }

        /// <summary>
        /// 收据
        /// </summary>
        public static EnumItem Receipt
        {
            get
            {
                return new EnumItem { Code = "02" };
            }
        }
    }
}
