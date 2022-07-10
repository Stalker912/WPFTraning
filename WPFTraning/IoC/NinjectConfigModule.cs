using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraning.ViewModels.Base;
using WPFTraning.ViewModels.IBase;

namespace WPFTraning.IoC
{
    internal class NinjectConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IViewModel>().To<ViewModel>();
        }
    }
}
