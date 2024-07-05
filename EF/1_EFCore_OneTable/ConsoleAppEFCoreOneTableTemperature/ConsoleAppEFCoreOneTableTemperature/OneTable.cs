using System;
using System.Collections.Generic;

namespace ConsoleAppEFCoreOneTableTemperature;

public partial class OneTable
{
    public int Id { get; set; }

    public string? Company { get; set; }

    public decimal? Temperature { get; set; }

    public DateTime? DateCreation { get; set; }
}
