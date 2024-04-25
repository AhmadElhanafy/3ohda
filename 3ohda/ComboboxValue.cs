﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ohda
{
    internal class ComboboxValue
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ComboboxValue(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}