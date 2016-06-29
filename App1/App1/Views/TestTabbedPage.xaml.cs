using System.Collections.Generic;
using Xamarin.Forms;

namespace App1.Views {
    public partial class TestTabbedPage : TabbedPage {
        public TestTabbedPage() {
            InitializeComponent();
            Children.Add(new ViewB());
            Children.Add(new ViewC());
        }
    }
}
