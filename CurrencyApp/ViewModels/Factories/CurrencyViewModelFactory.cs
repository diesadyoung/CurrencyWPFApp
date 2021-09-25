using CurrencyApp.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.ViewModels.Factories
{
    public class CurrencyViewModelFactory : ICurrencyViewModelFactory
    {
        private readonly CreateViewModel<HomeViewModel> _createHomeViewModel;

        public CurrencyViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel)
        {
            _createHomeViewModel = createHomeViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _createHomeViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}
