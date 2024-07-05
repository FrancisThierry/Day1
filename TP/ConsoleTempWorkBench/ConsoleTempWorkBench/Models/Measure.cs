using System;
using System.Collections.Generic;

namespace ConsoleTempWorkBench.Models;

public partial class Measure
{
    public int Id { get; set; }

    public int DeviceId { get; set; }

    public DateTime MeasurementDate { get; set; }

    public double? Temperature { get; set; }

    public virtual Device Device { get; set; } = null!;
}
