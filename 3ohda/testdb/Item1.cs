using System;
using System.Collections.Generic;

namespace _3ohda.testdb;

public partial class Item1
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public int? Quantity { get; set; }

    public string? NameOfTaker { get; set; }

    public DateTime DateTaken { get; set; }

    public string? PlaceTaken { get; set; }

    public sbyte Returned { get; set; }

    public int? QuantityReturned { get; set; }

    public DateTime? DateReturned { get; set; }

    public string? NotesOnReturn { get; set; }

    public string? SerialNumber { get; set; }
}
