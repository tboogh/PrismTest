using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using App1.Views;
using Prism.Navigation;

namespace App1.ViewModels {
    public class ViewCViewModel : BindableBase, INavigationAware {
        private readonly INavigationService _navigationService;
        public DelegateCommand ModalCommand { get; set; }

        public ViewCViewModel(INavigationService navigationService ) {
            _navigationService = navigationService;
            ModalCommand = new DelegateCommand(Modal);
        }

        private void Modal() {
            _navigationService.Navigate(nameof(ViewA));
        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"ViewCViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"ViewCViewModel OnNavigatedTo");
        }
    }
}
