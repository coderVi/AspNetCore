using System;
using System.Collections.Generic;

namespace AspNetCoreDBFirstMVC.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
