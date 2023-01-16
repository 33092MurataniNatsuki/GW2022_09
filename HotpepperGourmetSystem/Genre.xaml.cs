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
    /// Genre.xaml の相互作用ロジック
    /// </summary>
    public partial class Genre : Page {
        public Genre() {
            InitializeComponent();
        }

        private void goHome_Click(object sender, RoutedEventArgs e)
        {
            var home = new Home();
            NavigationService.Navigate(home);
        }

        private void goArea_Click(object sender, RoutedEventArgs e)
        {
            var area = new Area();
            NavigationService.Navigate(area);
        }
    }
}
