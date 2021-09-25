using CurrencyApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Currency.FinancialModelingPrepAPI;

namespace CurrencyApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MajorIndexService().GetMajorIndex(Services.Models.MajorIndexType.AUD).ContinueWith((task) =>
            {
                var index = task.Result;

            });

            base.OnStartup(e);
        }
    }
}
