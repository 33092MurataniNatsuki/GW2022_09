using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotpepperGourmetSystem {
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window {
        private NavigationService navi;
        public Window1() {
            InitializeComponent();

            Uri uri = new Uri("/Home.xaml", UriKind.Relative);
            frame.Source = uri;

            navi = this.frame.NavigationService;
        }

        private List<Uri> uriList = new List<Uri>() {
            new Uri("Home.xaml",UriKind.Relative),
            new Uri("Area.xaml",UriKind.Relative),
            new Uri("Genre.xaml",UriKind.Relative),
        };

        private void frame_Loaded(object sender, RoutedEventArgs e) {
            navi.Navigate(uriList[0]);
        }
    }
}
