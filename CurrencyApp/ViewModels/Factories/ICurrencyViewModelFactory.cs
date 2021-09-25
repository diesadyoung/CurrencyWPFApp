using CurrencyApp.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.ViewModels.Factories
{
    public interface ICurrencyViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
