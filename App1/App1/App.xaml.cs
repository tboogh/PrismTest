using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.ViewModels;
using App1.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace App1 {
    public partial class App : PrismApplication{
        protected override void OnInitialized() {
            InitializeComponent();
            NavigationService.Navigate("TestNavigationPage/MainPage/TestTabbedPage/ViewC");
        }

        protected override void RegisterTypes() {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<ViewA>();
            Container.RegisterTypeForNavigation<ViewB>();
            Container.RegisterTypeForNavigation<ViewC>();
            Container.RegisterTypeForNavigation<TestNavigationPage>();
            Container.RegisterTypeForNavigation<TestTabbedPage>();
        }
    }
}
