using System;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace App1.ViewModels {
    public class ViewAViewModel : BindableBase, INavigationAware {
        private readonly INavigationService _navigationService;
        public DelegateCommand CloseCommand { get; set; }

        public ViewAViewModel(INavigationService navigationService) {
            _navigationService = navigationService;
            CloseCommand = new DelegateCommand(Close);
        }

        private void Close() {
            _navigationService.GoBack();
        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"ViewAViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"ViewAViewModel OnNavigatedTo");
        }
    }
}
