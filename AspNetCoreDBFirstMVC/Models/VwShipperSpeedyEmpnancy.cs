using System;
using System.Collections.Generic;

namespace AspNetCoreDBFirstMVC.Models;

public partial class VwShipperSpeedyEmpnancy
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string CustomerCompanyName { get; set; } = null!;

    public string ShipperCompanyName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
