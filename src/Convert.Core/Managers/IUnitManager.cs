using Convert.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Core.Managers
{
    public interface IUnitManager
    {
        Task<List<Unit>> GetUnitsAsync(); 

        double Convert(double sourceValue,
            Unit sourceUnit,
            Unit targetUnit);
    }
}
