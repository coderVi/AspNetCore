using System;
using System.Collections.Generic;

namespace AspNetCoreDBFirstMVC.Models;

public partial class VwWithEncr
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public string CategoryName { get; set; } = null!;
}
