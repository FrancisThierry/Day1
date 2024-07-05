using System;
using System.Collections.Generic;

namespace ConsoleTempWorkBench.Models;

public partial class Device
{
    public int Id { get; set; }

    public int typeDevice { get; set; }

    public string DeviceName { get; set; } = null!;

    public virtual ICollection<Measure> Measures { get; set; } = new List<Measure>();
}
