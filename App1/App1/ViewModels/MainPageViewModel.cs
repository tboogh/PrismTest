using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using App1.Views;
using Prism.Navigation;

namespace App1.ViewModels {
    public class MainPageViewModel : BindableBase, INavigationAware {
        private readonly INavigationService _navigationService;
        string _title = "Main Page";
        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService ) {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }

        void Navigate() {
            _navigationService.Navigate(nameof(TestTabbedPage));
        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"MainPageViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"MainPageViewModel OnNavigatedTo");
        }
    }
}
