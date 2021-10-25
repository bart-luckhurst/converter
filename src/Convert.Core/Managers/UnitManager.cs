using Convert.Core.Entities;
using Convert.Core.Repositories;
using Convert.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Core.Managers
{
    public class UnitManager : IUnitManager
    {
        private readonly IUnitRepository _unitRepository;

        public UnitManager(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<List<Unit>> GetUnitsAsync()
        {
            return await _unitRepository.GetUnitsAsync();
        }

        public double Convert(double sourceValue,
            Unit sourceUnit,
            Unit targetUnit)
        {
            //convert to SI
            double siValue = sourceValue * sourceUnit.SiFactor;
            //convert to target
            double targetValue = siValue / targetUnit.SiFactor;
            //round to 7sf, as for some reason, 1m is rounding to 999.9999525mm
            double roundedTargetValue = targetValue.RoundToSignificantFigures(7);
            return roundedTargetValue;
        }
    }
}
