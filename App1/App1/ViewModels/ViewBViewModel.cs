using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace App1.ViewModels {
    public class ViewBViewModel : BindableBase, INavigationAware {
        public ViewBViewModel() {

        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"ViewBViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"ViewBViewModel OnNavigatedTo");
        }
    }
}
