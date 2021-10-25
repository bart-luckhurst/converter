using System;
using System.Collections.Generic;
using System.Text;

namespace Convert.Core.Entities
{
    public class Unit
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public double SiFactor { get; set; }

        public Unit(string name,
            string abbreviation,
            double siFactor)
        {
            Name = name;
            Abbreviation = abbreviation;
            SiFactor = siFactor;
        }

        public override string ToString()
        {
            return $"{Name} ({Abbreviation})";
        }
    }
}
