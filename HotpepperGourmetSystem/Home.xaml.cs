using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        string midleAreaCode;
        string genreCode;


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
                case "栃木県":
                    largeAreaCode = "Z017";
                    break;
                case "群馬県":
                    largeAreaCode = "Z021";
                    break;
                case "滋賀県":
                    largeAreaCode = "Z011";
                    break;
                case "京都府":
                    largeAreaCode = "Z022";
                    break;
                case "大阪府":
                    largeAreaCode = "Z023";
                    break;
                case "兵庫県":
                    largeAreaCode = "Z024";
                    break;
                case "奈良県":
                    largeAreaCode = "Z025";
                    break;
                case "和歌山県":
                    largeAreaCode = "Z026";
                    break;
                case "岐阜県":
                    largeAreaCode = "Z031";
                    break;
                case "静岡県":
                    largeAreaCode = "Z032";
                    break;
                case "愛知県":
                    largeAreaCode = "Z034";
                    break;
                case "三重県":
                    largeAreaCode = "Z035";
                    break;
                case "北海道":
                    largeAreaCode = "Z041";
                    break;
                case "青森県":
                    largeAreaCode = "Z051";
                    break;
                case "岩手県":
                    largeAreaCode = "Z052";
                    break;
                case "宮城県":
                    largeAreaCode = "Z053";
                    break;
                case "秋田県":
                    largeAreaCode = "Z054";
                    break;
                case "山形県":
                    largeAreaCode = "Z055";
                    break;
                case "福島県":
                    largeAreaCode = "Z056";
                    break;
                case "新潟県":
                    largeAreaCode = "Z061";
                    break;
                case "富山県":
                    largeAreaCode = "Z062";
                    break;
                case "石川県":
                    largeAreaCode = "Z063";
                    break;
                case "福井県":
                    largeAreaCode = "Z064";
                    break;
                case "山梨県":
                    largeAreaCode = "Z065";
                    break;
                case "長野県":
                    largeAreaCode = "Z066";
                    break;
                case "鳥取県":
                    largeAreaCode = "Z071";
                    break;
                case "島根県":
                    largeAreaCode = "Z072";
                    break;
                case "岡山県":
                    largeAreaCode = "Z073";
                    break;
                case "広島県":
                    largeAreaCode = "Z074";
                    break;
                case "山口県":
                    largeAreaCode = "Z075";
                    break;
                case "徳島県":
                    largeAreaCode = "Z081";
                    break;
                case "香川県":
                    largeAreaCode = "Z082";
                    break;
                case "愛媛県":
                    largeAreaCode = "Z083";
                    break;
                case "高知県":
                    largeAreaCode = "Z084";
                    break;
                case "福岡県":
                    largeAreaCode = "Z091";
                    break;
                case "佐賀県":
                    largeAreaCode = "Z092";
                    break;
                case "長崎県":
                    largeAreaCode = "Z093";
                    break;
                case "熊本県":
                    largeAreaCode = "Z094";
                    break;
                case "大分県":
                    largeAreaCode = "Z095";
                    break;
                case "宮崎県":
                    largeAreaCode = "Z096";
                    break;
                case "鹿児島県":
                    largeAreaCode = "Z097";
                    break;
                case "沖縄県":
                    largeAreaCode = "Z098";
                    break;
            }
        }

        private void MidleArea()
        {
            switch (lbCity.Content)
            {
                case "銀座・有楽町・新橋・築地・月島":
                    midleAreaCode = "Y005";
                    break;
                case "水道橋・飯田橋・神楽坂":
                    midleAreaCode = "Y006";
                    break;
                case "お台場":
                    midleAreaCode = "Y007";
                    break;
                case "東京・大手町・日本橋・人形町":
                    midleAreaCode = "Y010";
                    break;
            }
        }

        private void Genre()
        {
            switch (lbGenre.Content)
            {
                case "居酒屋":
                    genreCode = "G001";
                    break;
                case "ダイニングバー・バル":
                    genreCode = "G002";
                    break;
                case "創作料理":
                    genreCode = "G003";
                    break;
                case "和食":
                    genreCode = "G004";
                    break;
                case "洋食":
                    genreCode = "G005";
                    break;
                case "イタリアン・フレンチ":
                    genreCode = "G006";
                    break;
                case "中華":
                    genreCode = "G007";
                    break;
                case "焼肉・ホルモン":
                    genreCode = "G008";
                    break;
                case "韓国料理":
                    genreCode = "G017";
                    break;
                case "アジア・エスニック料理":
                    genreCode = "G009";
                    break;
                case "各国料理":
                    genreCode = "G010";
                    break;
                case "カラオケ・パーティ":
                    genreCode = "G011";
                    break;
                case "バー・カクテル":
                    genreCode = "G012";
                    break;
                case "ラーメン":
                    genreCode = "G013";
                    break;
                case "お好み焼き・もんじゃ":
                    genreCode = "G016";
                    break;
                case "カフェ・スイーツ":
                    genreCode = "G014";
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

            //btSearch.IsEnabled = false;
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

            //if (lbPref.Content != "" && lbCity.Content == "指定なし" && lbGenre.Content != "")
            //{
            //    Genre();
            //    LargeArea();

            //    //for (int i = 0; i < 10; i++)
            //    //{
            //    //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&genre=" + genreCode + "&format=json");
            //    //    //dString = dString.Replace("\"name\":\"ダイニングバー・バル\"", "\"name\":\"ダイニングバーバル\"");
            //    //    //dString = dString.Replace("\"name\":\"イタリアン・フレンチ\"", "\"name\":\"イタリアンフレンチ\"");
            //    //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    //    tbShopName1.Text = json1.results.shop[i].name;
            //    //    tbAddress1.Text = json1.results.shop[i].address;
            //    //    tbOpen1.Text = json1.results.shop[i].open;
            //    //    lbBudget1.Content = json1.results.shop[i].budget.name;
            //    //    tbCatchPhrase1.Text = json1.results.shop[i].other_memo;
            //    //    var imageUrl = json1.results.shop[i].logo_image;
            //    //    BitmapImage imagesorse = new BitmapImage(new Uri(imageUrl));
            //    //    im11.Source = imagesorse;
            //    //}
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&genre=" + genreCode + "&format=json");
            //    //dString = dString.Replace("\"name\":\"ダイニングバー・バル\"", "\"name\":\"ダイニングバーバル\"");
            //    //dString = dString.Replace("\"name\":\"イタリアン・フレンチ\"", "\"name\":\"イタリアンフレンチ\"");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    tbShopName1.Text = json1.results.shop[0].name;
            //    tbAddress1.Text = json1.results.shop[0].address;
            //    tbOpen1.Text = json1.results.shop[0].open;
            //    lbBudget1.Content = json1.results.shop[0].budget.name;
            //    tbCatchPhrase1.Text = json1.results.shop[0].other_memo;
            //    var imageUrl = json1.results.shop[0].logo_image;
            //    BitmapImage imagesorse = new BitmapImage(new Uri(imageUrl));
            //    im11.Source = imagesorse;
            //}

            //if (lbPref.Content != "" && lbCity.Content == "指定なし" && lbGenre.Content == "")
            //{
            //    Genre();
            //    LargeArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    tbShopName1.Text = json1.results.shop[0].name;
            //    tbAddress1.Text = json1.results.shop[0].address;
            //    tbOpen1.Text = json1.results.shop[0].open;
            //    lbBudget1.Content = json1.results.shop[0].budget.name;
            //    tbCatchPhrase1.Text = json1.results.shop[0].other_memo;
            //    var imageUrl1 = json1.results.shop[0].photo.pc.l;
            //    BitmapImage imagesorse1 = new BitmapImage(new Uri(imageUrl1));
            //    im11.Source = imagesorse1;
            //    var imageUrl2 = json1.results.shop[0].logo_image;
            //    BitmapImage imagesorse2 = new BitmapImage(new Uri(imageUrl2));
            //    im12.Source = imagesorse2;
            //}

            //if (lbPref.Content != "" && lbCity.Content != "" && lbGenre.Content == "")
            //{
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    tbShopName1.Text = json1.results.shop[0].name;
            //    tbAddress1.Text = json1.results.shop[0].address;
            //    tbOpen1.Text = json1.results.shop[0].open;
            //    lbBudget1.Content = json1.results.shop[0].budget.name;
            //    tbCatchPhrase1.Text = json1.results.shop[0].other_memo;
            //    var imageUrl1 = json1.results.shop[0].photo.pc.l;
            //    BitmapImage imagesorse1 = new BitmapImage(new Uri(imageUrl1));
            //    im11.Source = imagesorse1;
            //    var imageUrl2 = json1.results.shop[0].logo_image;
            //    BitmapImage imagesorse2 = new BitmapImage(new Uri(imageUrl2));
            //    im12.Source = imagesorse2;
            //}

            //if (lbPref.Content != "" && lbCity.Content != "" && lbGenre.Content != "")
            //{
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    tbShopName1.Text = json1.results.shop[0].name;
            //    tbAddress1.Text = json1.results.shop[0].address;
            //    tbOpen1.Text = json1.results.shop[0].open;
            //    lbBudget1.Content = json1.results.shop[0].budget.name;
            //    tbCatchPhrase1.Text = json1.results.shop[0].other_memo;
            //    var imageUrl1 = json1.results.shop[0].photo.pc.l;
            //    BitmapImage imagesorse1 = new BitmapImage(new Uri(imageUrl1));
            //    im11.Source = imagesorse1;
            //    var imageUrl2 = json1.results.shop[0].logo_image;
            //    BitmapImage imagesorse2 = new BitmapImage(new Uri(imageUrl2));
            //    im12.Source = imagesorse2;
            //}

            var codes = new MidleAreaCodeCounter("MidleAreaCode.csv");
            var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_are=" + midleAreaCode + "&format=json");
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            tbShopName1.Text = json1.results.shop[0].name;
        }
    }
}
