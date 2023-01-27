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
            lb1.Content = json.results.shop[0].access;

            string id2 = "Z011";
            var dString2 = wc.DownloadString(" http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + id2);
            var json2 = JsonConvert.DeserializeObject<Rootobject>(dString);
            //lbAccess1.Content = json2.results.shop[0].access;
            //tb1.Text = json2.results.shop[0].access;
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

            //MenuItem mi = new MenuItem();
            //mi.Header = "500円";
            //mi.IsEnabled = false;
            //cbBudgetMax.Items.Add(mi);

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

        private void cbBudgetMin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = new List<ComboBox>();
            var num = new ComboBox[] { cbBudgetMin };
            list.AddRange(num);

            var list2 = new List<int>();
            var index = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12, };
            list2.AddRange(index);

            for (int i2 = 0; i2 < index.Length; i2++)
            {
                if (cbBudgetMin.SelectedIndex == i2)
                {
                    for (int i1 = 1; i1 < num.Length; i1++)
                    {
                        num[i1].IsEnabled = false;
                    }
                }
            }
        }

        private void btClose_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            lbPref.Content = parent.selectedPref;
            lbCity.Content = parent.selectedArea;
            lbGenre.Content = parent.selectedGenre;

            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };



            //var list1 = new List<string>();
            //var largeAreaCode = new string[] { "Z011","Z012","Z013","Z014","Z015","Z016","Z017","Z021",
            //                              "Z022","Z023","Z024","Z025","Z026","Z031","Z032","Z033",
            //                              "Z034","Z041","Z051","Z052","Z053","Z054","Z055","Z056",
            //                              "Z061","Z062","Z063","Z064","Z065","Z066","Z071","Z072",
            //                              "Z073","Z074","Z075","Z081","Z082","Z083","Z084","Z091",
            //                              "Z092","Z093","Z094","Z095","Z096","Z097","Z098",
            //};
            //list1.AddRange(largeAreaCode);

            //var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area={0}",largeAreaCode[]);
            //var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //lbAccess1.Content = json.results.shop[0].access;

            //string id2 = "Z011";
            //var dString2 = wc.DownloadString(" http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + id2);
            //var json2 = JsonConvert.DeserializeObject<Rootobject>(dString2);
            //lbAccess1.Content = json2.results.shop[0].access;

        }
    }
}
