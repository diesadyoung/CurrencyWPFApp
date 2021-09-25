using Currency.FinancialModelingPrepAPI;
using CurrencyApp.State;
using CurrencyApp.ViewModels;
using CurrencyApp.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyApp.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        private readonly ICurrencyViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, ICurrencyViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch(viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel(MajorIndexViewModel.LoadMajorIndexViewModel(new MajorIndexService()));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
