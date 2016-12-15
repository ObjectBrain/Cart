using System;
using Microsoft.Practices.Unity;
using Presentation.Wpf.Ioc;

namespace Presentation.Wpf.ViewModel
{
    public class ViewModelLocator : IDisposable
    {
        private readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = UnityConfig.GetConfiguredContainer();
        }

        public MainViewModel Main => _container.Resolve<MainViewModel>();

        public ICustomerViewModel Customer => _container.Resolve<ICustomerViewModel>();

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}