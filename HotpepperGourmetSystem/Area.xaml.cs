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
    /// Area.xaml の相互作用ロジック
    /// </summary>
    public partial class Area : Page {
        public Area() {
            InitializeComponent();
        }

        private void goHome_Click(object sender, RoutedEventArgs e) {
            var home = new Home();
            NavigationService.Navigate(home);
        }

        private void goGenre_Click(object sender, RoutedEventArgs e) {
            var genre = new Genre();
            NavigationService.Navigate(genre);
        }

        private void goPicky_Click(object sender, RoutedEventArgs e) {
            var picky = new Picky();
            NavigationService.Navigate(picky);
        }

        private void goHistory_Click(object sender, RoutedEventArgs e) {
            var history = new History();
            NavigationService.Navigate(history);
        }
    }
}
