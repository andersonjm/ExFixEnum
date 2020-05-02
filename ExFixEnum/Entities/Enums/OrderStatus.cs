using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixEnum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
