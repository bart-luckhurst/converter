using Convert.Core.Entities;
using Convert.Core.Managers;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Convert.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        #region Binding Properties
        private List<Unit> _units;
        public List<Unit> Units
        {
            get { return _units; }
            set { SetProperty(ref _units, value); }
        }

        private double _sourceValue = 1.0d;
        public double SourceValue
        {
            get { return _sourceValue; }
            set { SetProperty(ref _sourceValue, value); Convert(); }
        }

        private Unit _sourceUnit;
        public Unit SourceUnit
        {
            get { return _sourceUnit; }
            set { SetProperty(ref _sourceUnit, value); Convert(); }
        }

        private Unit _targetUnit;
        public Unit TargetUnit
        {
            get { return _targetUnit; }
            set { SetProperty(ref _targetUnit, value); Convert(); }
        }

        private double _targetValue = 0d;
        public double TargetValue
        {
            get { return _targetValue; }
            set { SetProperty(ref _targetValue, value); }
        }
        #endregion

        private readonly IUnitManager _unitManager;

        public HomeViewModel(IUnitManager unitManager)
        {
            _unitManager = unitManager;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            await LoadUnitsAsync();
            Convert();
        }

        public IMvxCommand SwapUnitsCommand => new MvxCommand(SwapUnits);
        private void SwapUnits()
        {
            Unit previousTargetUnit = TargetUnit;
            TargetUnit = SourceUnit;
            SourceUnit = previousTargetUnit;
        }

        private void Convert()
        {
            if (SourceUnit != null && TargetUnit != null)
            {
                TargetValue = _unitManager.Convert(SourceValue,
                SourceUnit,
                TargetUnit);
            }
        }

        private async Task LoadUnitsAsync()
        {
            //load units
            Units = await _unitManager.GetUnitsAsync();
            //set default units
            SourceUnit = Units[1];
            TargetUnit = Units[0];
        }
    }
}
