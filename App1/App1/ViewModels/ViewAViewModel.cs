using System.Diagnostics;
using Prism.Mvvm;
using Prism.Navigation;

namespace App1.ViewModels {
    public class ViewAViewModel : BindableBase, INavigationAware {
        public ViewAViewModel() {

        }

        public void OnNavigatedFrom(NavigationParameters parameters) {
            Debug.WriteLine($"ViewAViewModel OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters) {
            Debug.WriteLine($"ViewAViewModel OnNavigatedTo");
        }
    }
}
