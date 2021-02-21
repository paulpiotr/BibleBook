using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BibleBook.Core.ViewModels.Root;

namespace BibleBook.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<RootViewModel>();
        }
    }
}
