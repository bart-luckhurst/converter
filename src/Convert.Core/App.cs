using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Convert.Core.ViewModels;
using MvvmCross;
using Convert.Core.Managers;
using Convert.Core.Repositories;

namespace Convert.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<HomeViewModel>();

            Mvx.IoCProvider.RegisterType<IUnitManager, UnitManager>();
            Mvx.IoCProvider.RegisterType<IUnitRepository, UnitRepository>();
        }
    }
}