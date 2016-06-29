using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace App1.ViewModels {
    public class ViewCViewModel : BindableBase, INavigationAware {
        public ViewCViewModel() {

        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"ViewCViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"ViewCViewModel OnNavigatedTo");
        }
    }
}
