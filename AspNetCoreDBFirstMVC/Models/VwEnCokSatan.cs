using System;
using System.Collections.Generic;

namespace AspNetCoreDBFirstMVC.Models;

public partial class VwEnCokSatan
{
    public string ProductName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public int? OrderCount { get; set; }
}
