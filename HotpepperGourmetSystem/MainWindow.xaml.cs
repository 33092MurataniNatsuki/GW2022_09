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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class Login : Window {
        public Login() {
            InitializeComponent();

            tbUserName.Text = "Username";
            tbUserName.Foreground = Brushes.DarkGray;
            tbPassWord.Text = "PassWord";
            tbPassWord.Foreground = Brushes.DarkGray;

            lbLogin.Foreground = Brushes.White;
            lbLogin.Background = Brushes.Firebrick;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            tbUserName.Text = "aaaa";
            tbPassWord.Text = "aaaa";

            if (tbUserName.Text == "aaaa" && tbPassWord.Text == "aaaa") {
                Window1 window1 = new Window1();
                window1.Show();
                Close();
            }

            
        }
    }
}
