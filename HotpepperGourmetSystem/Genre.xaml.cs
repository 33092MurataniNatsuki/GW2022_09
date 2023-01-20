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

        //親ウィンドウのインスタンスを取得
        Window1 parent = (Window1)Application.Current.MainWindow;

        public Genre() {
            InitializeComponent();
        }

        private void goHome_Click(object sender, RoutedEventArgs e)
        {
            homeGo();
        }

        private void homeGo()
        {
            var home = new Home();
            NavigationService.Navigate(home);
        }

        private void goArea_Click(object sender, RoutedEventArgs e)
        {
            var area = new Area();
            NavigationService.Navigate(area);
        }

        private void SelectGenre()
        {
            parent.selectedGenre = (string)lbGenreName.Content;
        }

        private void btTavern_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btTavern.Content;
            SelectGenre();
            homeGo();
        }

        private void btDiningBar_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btDiningBar.Content;
            SelectGenre();
            homeGo();
        }

        private void btCreativeCooking_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btCreativeCooking.Content;
            SelectGenre();
            homeGo();
        }

        private void btJapaneseFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btJapaneseFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btWesteraFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btWesteraFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btItalian_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btItalian.Content;
            SelectGenre();
            homeGo();
        }

        private void btChineseFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btChineseFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btGrilledMeat_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btGrilledMeat.Content;
            SelectGenre();
            homeGo();
        }

        private void btTopKoreaFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btTopKoreaFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btAsiaFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btAsiaFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btInternationalFood_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btInternationalFood.Content;
            SelectGenre();
            homeGo();
        }

        private void btKaraoke_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btKaraoke.Content;
            SelectGenre();
            homeGo();
        }

        private void btBar_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btBar.Content;
            SelectGenre();
            homeGo();
        }

        private void btRamen_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btRamen.Content;
            SelectGenre();
            homeGo();
        }

        private void btOkonomiyaki_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btOkonomiyaki.Content;
            SelectGenre();
            homeGo();
        }

        private void btCafe_Click(object sender, RoutedEventArgs e)
        {
            lbGenreName.Content = btCafe.Content;
            SelectGenre();
            homeGo();
        }
    }
}
