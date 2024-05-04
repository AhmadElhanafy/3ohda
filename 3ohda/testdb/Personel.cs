using System;
using System.Collections.Generic;

namespace _3ohda.testdb;

public partial class Personel
{
    public int Id { get; set; }

    public string? Rank { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Custody> Custodies { get; set; } = new List<Custody>();
}
