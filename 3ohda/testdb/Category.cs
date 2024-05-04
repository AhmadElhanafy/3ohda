﻿using System;
using System.Collections.Generic;

namespace _3ohda.testdb;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
