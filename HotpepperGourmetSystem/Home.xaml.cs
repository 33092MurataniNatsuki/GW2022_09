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

        string largeAreaCode;

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

            //lb1.Content = json.results.shop[0].access;


        }


        private void LargeArea()
        {
            switch (lbPref.Content)
            {
                case "東京都":
                    largeAreaCode = "Z011";
                    break;
                case "神奈川県":
                    largeAreaCode = "Z012";
                    break;
                case "埼玉県":
                    largeAreaCode = "Z013";
                    break;
                case "千葉県":
                    largeAreaCode = "Z014";
                    break;
                case "茨城県":
                    largeAreaCode = "Z015";
                    break;
                case "北海道":
                    largeAreaCode = "Z016";
                    break;
                case "栃木県":
                    largeAreaCode = "Z017";
                    break;
                case "群馬県":
                    largeAreaCode = "Z021";
                    break;
                case "滋賀県":
                    largeAreaCode = "Z011";
                    break;
            }
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
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            //var list = new List<string>();
            //var largeAreaCode = new string[] { "011000","012000","013000","014100","015000","016000","017000","020000",
            //                              "030000","040000","050000","060000","070000","080000","090000","100000",
            //                              "110000","120000","130000","140000","190000","200000","210000","220000",
            //                              "230000","240000","150000","160000","170000","180000","250000","260000",
            //                              "270000","280000","290000","300000","310000","320000","330000","340000",
            //                              "360000","370000","380000","390000","350000","400000","410000","420000",
            //                              "430000","440000","450000","460040","460100","471000","472000","473000","474000",
            //};
            //list.AddRange(largeAreaCode);


            LargeArea();
            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode  +"&format=json");
            //dString = dString.Replace("\"name\":\"ダイニングバー・バル\"", "\"name\":\"ダイニングバーバル\"");
            //dString = dString.Replace("\"name\":\"イタリアン・フレンチ\"", "\"name\":\"イタリアンフレンチ\"");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbAddress1.Text = json.results.shop[0].address;


        }
    }
}
