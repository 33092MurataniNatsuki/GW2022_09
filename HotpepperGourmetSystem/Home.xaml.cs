using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Home.xaml の相互作用ロジック
    /// </summary>
    public partial class Home : Page {
        public Home() {


            InitializeComponent();

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            string id = "J001239297";

            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&id=" + id + "&format=json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            //lbMaxTempToday.Text = json2[1].timeSeries[1].areas[0].tempsMax[1];

            lb1.Content = json.results.shop[0].access;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var area = new Area();
            NavigationService.Navigate(area);
        }

        private void goGenre_Click_1(object sender, RoutedEventArgs e) {
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
