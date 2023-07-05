using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiTest.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand CounterCommand { get; }
        public ICommand OpenDetailedPageCommand { get; }
    }
}
