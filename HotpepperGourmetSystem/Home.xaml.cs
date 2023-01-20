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

        //親ウィンドウのインスタンスを取得
        Window1 parent = (Window1)Application.Current.MainWindow;

        public Home() {

            InitializeComponent();

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            lbPref.Content = parent.selectedPref;
            lbCity.Content = parent.selectedArea;
            lbGenre.Content = parent.selectedGenre;

            string id = "J001239297";

            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&id=" + id + "&format=json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            //lbMaxTempToday.Text = json2[1].timeSeries[1].areas[0].tempsMax[1];

            lb1.Content = json.results.shop[0].access;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cbBudgetMin.SelectedItem = "指定なし";
            cbBudgetMax.SelectedItem = "指定なし";
            cbNumber.SelectedItem = "指定なし";

            cbBudgetMin.ItemsSource = new string[]
            {
                "指定なし",
                "501円",
                "1001円",
                "1501円",
                "2001円",
                "3001円",
                "4001円",
                "5001円",
                "7001円",
                "10001円",
                "15001円",
                "20001円",
                "30001円",
            };

            cbBudgetMax.ItemsSource = new string[]
            {
                "指定なし",
                "500円",
                "1000円",
                "1500円",
                "2000円",
                "3000円",
                "4000円",
                "5000円",
                "7000円",
                "10000円",
                "15000円",
                "20000円",
                "30000円",
            };

            cbNumber.ItemsSource = new string[]
            {
                "指定なし",
                "1名",
                "2名",
                "3名",
                "4名",
                "5名",
                "6名",
                "7名",
                "8名",
                "9名",
                "10名",
                "20名",
                "30名",
                "40名",
                "50名",
                "60名",
                "70名",
                "80名",
                "90名",
                "100名",
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var area = new Area();
            NavigationService.Navigate(area);
        }

        private void goGenre_Click_1(object sender, RoutedEventArgs e) {
            var genre = new Genre();
            NavigationService.Navigate(genre);
        }

        
    }
}
