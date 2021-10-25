using Convert.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Core.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        public async Task<List<Unit>> GetUnitsAsync()
        {
            List<Unit> dummyOutput = new List<Unit>()
            {
                new Unit("Metres", "m", 1d),
                new Unit("Centimetres", "cm", 0.01d),
                new Unit("Millimetres", "mm", 0.001d),
                new Unit("Inches", "in", 0.0254d),
                new Unit("Feet", "ft", 0.3048d),
                new Unit("Yards", "yd", 0.9144d),
                new Unit("Lego Units", "LU", 0.0016d),
            };
            return dummyOutput;
        }
    }
}
