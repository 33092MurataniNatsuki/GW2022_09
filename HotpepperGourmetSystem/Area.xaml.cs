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
    /// Area.xaml の相互作用ロジック
    /// </summary>
    public partial class Area : Page
    {
        NavigationService _navigation;
        public Area() {
            InitializeComponent();

            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string id = "J001239297";

            //var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&id=" + id + "&format=json");
            //var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/middle_area/v1/?key=0e8af5f2f79eb4f4&middle_area&format=json");
            var json = JsonConvert.DeserializeObject<Middle_Area>(dString);

            //lb1.Content = json.results.shop[0].access;
        }

        private void goHome_Click(object sender, RoutedEventArgs e) {
            var home = new Home();
            NavigationService.Navigate(home);

            //Application.Current.Properties["Name"] = rb1.Content;
            //_navigation.Navigate(home);
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

        private void btHokkaido_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "すすきの";
            rb2.Content = "室蘭・登別・白老";
            rb3.Content = "富良野・その他北海道";
            rb4.Content = "札幌（札幌駅・大通）";
            rb5.Content = "麻生・北24条（北区・東区）";
            rb6.Content = "南郷・新札幌　白石・厚別・清田";
            rb7.Content = "琴似・円山公園　中央・西・手稲";
            rb8.Content = "平岸・澄川（豊平区・南区）";
            rb9.Content = "旭川";
            rb10.Content = "函館";
            rb11.Content = "小樽・千歳・苫小牧・札幌近郊";
            rb12.Content = "帯広・釧路・北見・河東郡";

            rb13.Content = "渋谷";
            rb14.Content = "原宿・青山・表参道";
            rb15.Content = "恵比寿・中目黒・代官山・広尾";
            rb16.Content = "赤坂・六本木・麻布十番・西麻布";
            rb17.Content = "自由が丘・田園調布";
        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            //var list = new List<string>();
            //var tokyoArea = new string[] { "011000","012000","013000","014100","015000","016000","017000","020000",
            //                              "030000","040000","050000","060000","070000","080000","090000","100000",
            //                              "110000","120000","130000","140000","190000","200000","210000","220000",
            //};
            //list.AddRange(tokyoArea);

            //foreach (var item in collection)
            //{

            //}

            rb1.Content = "銀座・有楽町・新橋・築地・月島";
            rb2.Content = "水道橋・飯田橋・神楽坂";
            rb3.Content = "お台場";
            rb4.Content = "東京・大手町・日本橋・人形町";
            rb5.Content = "四ツ谷・麹町・市ヶ谷・九段下";
            rb6.Content = "上野・御徒町・浅草";
            rb7.Content = "北千住・日暮里・葛飾・荒川";
            rb8.Content = "錦糸町・浅草橋・両国・亀戸";
            rb9.Content = "門前仲町・東陽町・木場・葛西";
            rb10.Content = "神田・神保町・秋葉原・御茶ノ水";
            rb11.Content = "品川･目黒･田町･浜松町･五反田";
            rb12.Content = "蒲田・大森・大田区";
            rb13.Content = "渋谷";
            rb14.Content = "原宿・青山・表参道";
            rb15.Content = "恵比寿・中目黒・代官山・広尾";
            rb16.Content = "赤坂・六本木・麻布十番・西麻布";
            rb17.Content = "自由が丘・田園調布";
            rb18.Content = "池袋";
            rb19.Content = "赤羽・王子・十条";
            rb20.Content = "新宿";
            rb21.Content = "新大久保・大久保";
            rb22.Content = "巣鴨・大塚・駒込";
            rb23.Content = "中野・高円寺・阿佐ヶ谷・方南町";
            rb24.Content = "下北沢・代々木上原";
            rb25.Content = "高田馬場";
            rb26.Content = "池尻大橋・三軒茶屋・駒沢大学";
            rb27.Content = "桜新町・用賀・二子玉川";
            rb28.Content = "祐天寺・学芸大学・都立大学";
            rb29.Content = "幡ヶ谷・笹塚・明大前・下高井戸";
            rb30.Content = "調布・府中・千歳烏山・仙川";
            rb31.Content = "経堂・千歳船橋";
            rb32.Content = "祖師ヶ谷大蔵・成城学園前";
            rb33.Content = "大井町･中延･旗の台･戸越･馬込";
            rb34.Content = "不動前・武蔵小山";
            rb35.Content = "雪が谷大塚・池上";
            rb36.Content = "武蔵小金井";
            rb37.Content = "国立・国分寺";

            rb38.Content = "青梅・昭島・小作・青梅線沿線";
            rb39.Content = "多摩センター・南大沢";
            rb40.Content = "吉祥寺・荻窪・三鷹";
            rb41.Content = "町田";
            rb42.Content = "八王子・立川";
            rb43.Content = "西武池袋線（石神井公園～秋津）";
            rb44.Content = "西武新宿線(中井～田無～東村山)";
            rb45.Content = "練馬・板橋・成増・江古田";
            rb46.Content = "都営三田線（新板橋～西高島平）";
            rb47.Content = "聖蹟桜ヶ丘・高幡不動・分倍河原";
            rb48.Content = "東京都その他";
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "武蔵小杉・元住吉・新丸子";
            rb2.Content = "新横浜・綱島・菊名・鴨居";
            rb3.Content = "大和・中央林間・長津田";
            rb4.Content = "新百合ヶ丘・登戸";
            rb5.Content = "横浜";
            rb6.Content = "桜木町みなとみらい･関内･中華街";
            rb7.Content = "上大岡・杉田・新杉田・金沢文庫";
            rb8.Content = "センター北・南、仲町台・都筑区";
            rb9.Content = "川崎・鶴見";
            rb10.Content = "本厚木･相模大野･海老名･伊勢原";
            rb11.Content = "相模原・橋本・淵野辺";
            rb12.Content = "大船・戸塚・東戸塚・保土ヶ谷";
            rb13.Content = "藤沢・辻堂茅ヶ崎・平塚・湘南台";
            rb14.Content = "鎌倉・江の島";
            rb15.Content = "小田原・箱根・湯河原・真鶴";
            rb16.Content = "横須賀中央・三浦・久里浜・汐入";
            rb17.Content = "逗子・葉山";
            rb18.Content = "神奈川県その他";

            for (int i = 19; i < 49; i++)
            {
                //rb + i.IsEnabled = false;
            }

            rb19.IsEnabled = false;
            rb20.IsEnabled = false;
            rb21.IsEnabled = false;
            rb22.IsEnabled = false;
            rb23.IsEnabled = false;
            rb24.IsEnabled = false;
            rb25.IsEnabled = false;
            rb26.IsEnabled = false;
            rb27.IsEnabled = false;
            rb28.IsEnabled = false;
            rb29.IsEnabled = false;
            rb30.IsEnabled = false;
            rb31.IsEnabled = false;
            rb32.IsEnabled = false;
            rb33.IsEnabled = false;
            rb34.IsEnabled = false;
            rb35.IsEnabled = false;
            rb36.IsEnabled = false;
            rb37.IsEnabled = false;
            rb38.IsEnabled = false;
            rb39.IsEnabled = false;
            rb40.IsEnabled = false;
            rb41.IsEnabled = false;
            rb42.IsEnabled = false;
            rb43.IsEnabled = false;
            rb44.IsEnabled = false;
            rb45.IsEnabled = false;
            rb46.IsEnabled = false;
            rb47.IsEnabled = false;
            rb48.IsEnabled = false;
        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "千葉・稲毛";
            rb2.Content = "船橋･津田沼･市川･本八幡･中山";
            rb3.Content = "南房総・館山";
            rb4.Content = "千葉県その他";
            rb4.Content = "柏・南柏・我孫子";
            rb5.Content = "舞浜・浦安・行徳・妙典下";
            rb6.Content = "成田・佐倉";
            rb7.Content = "海浜幕張";
            rb8.Content = "蘇我・鎌取・茂原";
            rb9.Content = "松戸・新松戸";
            rb10.Content = "銚子・旭";
            rb11.Content = "木更津・市原";

            rb12.IsEnabled = false;
            rb13.IsEnabled = false;
            rb14.IsEnabled = false;
            rb15.IsEnabled = false;
            rb16.IsEnabled = false;
            rb17.IsEnabled = false;
            rb18.IsEnabled = false;
            rb19.IsEnabled = false;
            rb20.IsEnabled = false;
            rb21.IsEnabled = false;
            rb22.IsEnabled = false;
            rb23.IsEnabled = false;
            rb24.IsEnabled = false;
            rb25.IsEnabled = false;
            rb26.IsEnabled = false;
            rb27.IsEnabled = false;
            rb28.IsEnabled = false;
            rb29.IsEnabled = false;
            rb30.IsEnabled = false;
            rb31.IsEnabled = false;
            rb32.IsEnabled = false;
            rb33.IsEnabled = false;
            rb34.IsEnabled = false;
            rb35.IsEnabled = false;
            rb36.IsEnabled = false;
            rb37.IsEnabled = false;
            rb38.IsEnabled = false;
            rb39.IsEnabled = false;
            rb40.IsEnabled = false;
            rb41.IsEnabled = false;
            rb42.IsEnabled = false;
            rb43.IsEnabled = false;
            rb44.IsEnabled = false;
            rb45.IsEnabled = false;
            rb46.IsEnabled = false;
            rb47.IsEnabled = false;
            rb48.IsEnabled = false;
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "大宮・さいたま新都心";
            rb2.Content = "川口・西川口・蕨";
            rb3.Content = "浦和・武蔵浦和";
            rb4.Content = "熊谷・深谷・本庄";
            rb5.Content = "東松山・坂戸";
            rb6.Content = "秩父";
            rb7.Content = "戸田";
            rb8.Content = "上尾・北上尾・蓮田";
            rb9.Content = "埼玉県その他";
            rb10.Content = "所沢";
            rb11.Content = "西武新宿線（航空公園～南大塚）";
            rb12.Content = "東武東上線 和光市～新河岸･新座";
            rb13.Content = "西武池袋線（小手指～飯能）";
            rb14.Content = "川越";
            rb15.Content = "春日部・越谷・草加・三郷";

            rb16.IsEnabled = false;
            rb17.IsEnabled = false;
            rb18.IsEnabled = false;
            rb19.IsEnabled = false;
            rb20.IsEnabled = false;
            rb21.IsEnabled = false;
            rb22.IsEnabled = false;
            rb23.IsEnabled = false;
            rb24.IsEnabled = false;
            rb25.IsEnabled = false;
            rb26.IsEnabled = false;
            rb27.IsEnabled = false;
            rb28.IsEnabled = false;
            rb29.IsEnabled = false;
            rb30.IsEnabled = false;
            rb31.IsEnabled = false;
            rb32.IsEnabled = false;
            rb33.IsEnabled = false;
            rb34.IsEnabled = false;
            rb35.IsEnabled = false;
            rb36.IsEnabled = false;
            rb37.IsEnabled = false;
            rb38.IsEnabled = false;
            rb39.IsEnabled = false;
            rb40.IsEnabled = false;
            rb41.IsEnabled = false;
            rb42.IsEnabled = false;
            rb43.IsEnabled = false;
            rb44.IsEnabled = false;
            rb45.IsEnabled = false;
            rb46.IsEnabled = false;
            rb47.IsEnabled = false;
            rb48.IsEnabled = false;
        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "名古屋（名古屋駅/西区/中村区）";
            rb2.Content = "栄ｷﾀ錦/伏見丸の内/泉/東桜/新栄";
            rb3.Content = "栄(ミナミ)/矢場町/大須/上前津";
            rb4.Content = "金山・神宮前・熱田区";
            rb5.Content = "鶴舞・八事・御器所";
            rb6.Content = "大曽根･千種･今池･池下･守山区";
            rb7.Content = "緑区・南区・天白区・瑞穂区";
            rb8.Content = "本山・覚王山・藤が丘";
            rb9.Content = "豊田市";
            rb10.Content = "中川区・港区";
            rb11.Content = "名古屋市その他";
            rb12.Content = "安城・刈谷・岡崎・知立・蒲郡";
            rb13.Content = "半田・知多・碧南・西尾";
            rb14.Content = "春日井・小牧・一宮・江南・瀬戸";
            rb15.Content = "豊橋・豊川";
            rb16.Content = "愛知県その他";

            rb17.IsEnabled = false;
            rb18.IsEnabled = false;
            rb19.IsEnabled = false;
            rb20.IsEnabled = false;
            rb21.IsEnabled = false;
            rb22.IsEnabled = false;
            rb23.IsEnabled = false;
            rb24.IsEnabled = false;
            rb25.IsEnabled = false;
            rb26.IsEnabled = false;
            rb27.IsEnabled = false;
            rb28.IsEnabled = false;
            rb29.IsEnabled = false;
            rb30.IsEnabled = false;
            rb31.IsEnabled = false;
            rb32.IsEnabled = false;
            rb33.IsEnabled = false;
            rb34.IsEnabled = false;
            rb35.IsEnabled = false;
            rb36.IsEnabled = false;
            rb37.IsEnabled = false;
            rb38.IsEnabled = false;
            rb39.IsEnabled = false;
            rb40.IsEnabled = false;
            rb41.IsEnabled = false;
            rb42.IsEnabled = false;
            rb43.IsEnabled = false;
            rb44.IsEnabled = false;
            rb45.IsEnabled = false;
            rb46.IsEnabled = false;
            rb47.IsEnabled = false;
            rb48.IsEnabled = false;
        }

        private void btShizuoka_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "静岡駅周辺・葵区・駿河区";
            rb2.Content = "清水駅周辺～草薙";
            rb3.Content = "浜松";
            rb4.Content = "伊豆・伊東・下田";
            rb5.Content = "焼津・藤枝・掛川";
            rb6.Content = "熱海";
            rb7.Content = "富士宮";
            rb8.Content = "静岡県その他";
            rb9.Content = "御殿場・富士・沼津・三島";

            rb10.IsEnabled = false;
            rb11.IsEnabled = false;
            rb12.IsEnabled = false;
            rb13.IsEnabled = false;
            rb14.IsEnabled = false;
            rb15.IsEnabled = false;
            rb16.IsEnabled = false;
            rb17.IsEnabled = false;
            rb18.IsEnabled = false;
            rb19.IsEnabled = false;
            rb20.IsEnabled = false;
            rb21.IsEnabled = false;
            rb22.IsEnabled = false;
            rb23.IsEnabled = false;
            rb24.IsEnabled = false;
            rb25.IsEnabled = false;
            rb26.IsEnabled = false;
            rb27.IsEnabled = false;
            rb28.IsEnabled = false;
            rb29.IsEnabled = false;
            rb30.IsEnabled = false;
            rb31.IsEnabled = false;
            rb32.IsEnabled = false;
            rb33.IsEnabled = false;
            rb34.IsEnabled = false;
            rb35.IsEnabled = false;
            rb36.IsEnabled = false;
            rb37.IsEnabled = false;
            rb38.IsEnabled = false;
            rb39.IsEnabled = false;
            rb40.IsEnabled = false;
            rb41.IsEnabled = false;
            rb42.IsEnabled = false;
            rb43.IsEnabled = false;
            rb44.IsEnabled = false;
            rb45.IsEnabled = false;
            rb46.IsEnabled = false;
            rb47.IsEnabled = false;
            rb48.IsEnabled = false;
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "鳥取市";
            rb2.Content = "米子市";

            rb3.Content = "大津";
            rb4.Content = "長浜市・彦根市";
            rb5.Content = "近江八幡市・東近江市";

        }

        private void btShimane_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "松江";
            rb2.Content = "出雲市";

            rb3.Content = "大津";
        }

        private void btShiga_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "草津市・守山市";
            rb2.Content = "滋賀県その他";
            rb3.Content = "大津";
            rb4.Content = "長浜市・彦根市";
            rb5.Content = "近江八幡市・東近江市";

            rb6.Content = "天王寺";
        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "伊勢";
            rb2.Content = "松阪";
            rb3.Content = "松阪";
            rb4.Content = "四日市";
            rb5.Content = "津";
            rb6.Content = "鈴鹿";
            rb7.Content = "鳥羽・志摩";
        }

        private void btNara_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "奈良市";
            rb2.Content = "天理市・橿原市";
            rb3.Content = "大和郡山市・生駒市";

            rb4.Content = "長浜市・彦根市";
            rb5.Content = "近江八幡市・東近江市";
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "梅田";
            rb2.Content = "福島・野田";
            rb3.Content = "淀屋橋・本町・北浜・天満橋";
            rb4.Content = "京橋・天満・天六・南森町";
            rb5.Content = "心斎橋・なんば・南船場・堀江";
            rb6.Content = "天王寺";
            rb7.Content = "上本町・鶴橋";
            rb8.Content = "針中野･長居･西田辺･西成区･住吉";
            rb9.Content = "関目・千林・緑橋・深江橋";
            rb10.Content = "堺・高石市・和泉市";
            rb11.Content = "高槻";
            rb12.Content = "茨木";
            rb13.Content = "泉大津･岸和田･泉佐野･りんくう";
            rb14.Content = "松原市･藤井寺市･富田林･南河内";
            rb15.Content = "江坂・西中島・新大阪・十三";
            rb16.Content = "東大阪市・八尾市・平野・大東市";
            rb17.Content = "九条･西九条･弁天町･大正･住之江";
            rb18.Content = "枚方・寝屋川・守口・門真";
            rb19.Content = "大阪府その他";
            rb20.Content = "箕面・池田";

            rb21.Content = "新大久保・大久保";
            rb22.Content = "巣鴨・大塚・駒込";
            rb23.Content = "中野・高円寺・阿佐ヶ谷・方南町";
            rb24.Content = "下北沢・代々木上原";
            rb25.Content = "高田馬場";
            rb26.Content = "池尻大橋・三軒茶屋・駒沢大学";
            rb27.Content = "桜新町・用賀・二子玉川";
            rb28.Content = "祐天寺・学芸大学・都立大学";
            rb29.Content = "幡ヶ谷・笹塚・明大前・下高井戸";
            rb30.Content = "調布・府中・千歳烏山・仙川";
            rb31.Content = "経堂・千歳船橋";
            rb32.Content = "祖師ヶ谷大蔵・成城学園前";
            rb33.Content = "大井町･中延･旗の台･戸越･馬込";
            rb34.Content = "不動前・武蔵小山";
            rb35.Content = "雪が谷大塚・池上";
            rb36.Content = "武蔵小金井";
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "烏丸御池・四条烏丸";
            rb2.Content = "左京区・山科区";
            rb3.Content = "北区・上京区";
            rb4.Content = "河原町・木屋町";
            rb5.Content = "祇園・先斗町";
            rb6.Content = "四条大宮・西院・右京区・西京区";
            rb7.Content = "烏丸五条・京都駅周辺";
            rb8.Content = "宮津・京丹後・京都府その他";
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "神戸";
            rb2.Content = "明石";
            rb3.Content = "灘・東灘";
            rb4.Content = "須磨・垂水・西区・兵庫・長田";
            rb5.Content = "姫路";
            rb6.Content = "加古川";
            rb7.Content = "淡路島";
            rb8.Content = "西宮・芦屋・宝塚";
            rb9.Content = "城崎・豊岡";
            rb10.Content = "北区・有馬温泉・三田";
            rb11.Content = "尼崎";
            rb12.Content = "兵庫県その他";

            rb13.Content = "泉大津･岸和田･泉佐野･りんくう";
            rb14.Content = "松原市･藤井寺市･富田林･南河内";
            rb15.Content = "江坂・西中島・新大阪・十三";
            rb16.Content = "東大阪市・八尾市・平野・大東市";
        }

        private void btWakayama_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "白浜・和歌山県その他";
            rb2.Content = "和歌山市";
            rb3.Content = "田辺市";

            rb4.Content = "須磨・垂水・西区・兵庫・長田";
        }

        private void btIwate_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "宮古・岩手県その他";
            rb2.Content = "盛岡";
            rb3.Content = "花巻・北上・奥州・一関";

            rb4.Content = "札幌（札幌駅・大通）";
            rb5.Content = "麻生・北24条（北区・東区）";
            rb6.Content = "南郷・新札幌　白石・厚別・清田";
            rb7.Content = "琴似・円山公園　中央・西・手稲";
            rb8.Content = "平岸・澄川（豊平区・南区）";
            rb9.Content = "旭川";
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "仙台（仙台駅周辺）";
            rb2.Content = "宮城県その他";
            rb3.Content = "青葉・宮城野・若林";
            rb4.Content = "仙台（国分町・一番町周辺）";
            rb5.Content = "泉中央";
            rb6.Content = "長町";
            rb7.Content = "大崎市";

            rb8.Content = "平岸・澄川（豊平区・南区）";
            rb9.Content = "旭川";
        }

        private void btHukushima_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "郡山";
            rb2.Content = "会津若松";
            rb3.Content = "喜多方";
            rb4.Content = "福島市";
            rb5.Content = "いわき・福島県その他";

            rb6.Content = "長町";
            rb7.Content = "琴似・円山公園　中央・西・手稲";
            rb8.Content = "平岸・澄川（豊平区・南区）";
            rb9.Content = "旭川";
        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "宇都宮";
            rb2.Content = "栃木県その他";
            rb3.Content = "日光・鹿沼";
            rb4.Content = "那須・塩原";
            rb5.Content = "小山市・栃木市";
            rb6.Content = "足利市・佐野市";

            rb7.Content = "烏丸五条・京都駅周辺";
        }

        private void btHiroshima_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "広島市（広島市中心部）";
            rb2.Content = "広島駅・横川・その他広島市内";
            rb3.Content = "福山";
            rb4.Content = "尾道";
            rb5.Content = "呉";
            rb6.Content = "広島県その他";

            rb7.Content = "烏丸五条・京都駅周辺";
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "岡山市";
            rb2.Content = "倉敷（倉敷市中心部）";
            rb3.Content = "倉敷(倉敷市郊外･児島･水島など)";
            rb4.Content = "備前・岡山県その他";

            rb5.Content = "吉塚・香椎・その他東エリア";
            rb6.Content = "大名・今泉・警固";
            rb7.Content = "薬院･平尾･高砂";
            rb8.Content = "大橋･その他南地区";
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "萩・山口県その他";
            rb2.Content = "下関";
            rb3.Content = "山口市";
            rb4.Content = "宇部市";
            rb5.Content = "周南市・下松市";
            rb6.Content = "岩国";
            rb7.Content = "防府";

            rb8.Content = "平岸・澄川（豊平区・南区）";
            rb9.Content = "旭川";

        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "高松市中心部";
            rb2.Content = "高松市郊外";
            rb3.Content = "坂出・香川県その他";
        }

        private void btTokushima_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "徳島市・徳島市周辺部";
            rb2.Content = "高松市郊外";
            rb3.Content = "徳島県その他";

            rb4.Content = "備前・岡山県その他";
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "松山";
            rb2.Content = "今治";
            rb3.Content = "宇和島･東予･南予･愛媛県その他";
            rb4.Content = "新居浜・西条";

            rb5.Content = "吉塚・香椎・その他東エリア";
            rb6.Content = "大名・今泉・警固";
            rb7.Content = "薬院･平尾･高砂";

        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btHukuoka_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "博多";
            rb2.Content = "中洲・中洲川端";
            rb3.Content = "天神・西中洲・春吉";
            rb4.Content = "西新・姪浜・その他西エリア";
            rb5.Content = "吉塚・香椎・その他東エリア";
            rb6.Content = "大名・今泉・警固";
            rb7.Content = "薬院･平尾･高砂";
            rb8.Content = "大橋･その他南地区";
            rb9.Content = "北九州（小倉・門司）";
            rb10.Content = "北九州（八幡・黒崎・折尾）";
            rb11.Content = "飯塚・筑紫野";
            rb12.Content = "久留米";
            rb13.Content = "福岡県その他";

            rb14.Content = "松原市･藤井寺市･富田林･南河内";
            rb15.Content = "江坂・西中島・新大阪・十三";
            rb16.Content = "東大阪市・八尾市・平野・大東市";
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "長崎市";
            rb2.Content = "佐世保・長崎県その他";
            rb3.Content = "天神・西中洲・春吉";
            rb4.Content = "西新・姪浜・その他西エリア";
            rb5.Content = "吉塚・香椎・その他東エリア";
            rb6.Content = "大名・今泉・警固";
            rb7.Content = "薬院･平尾･高砂";
            rb8.Content = "大橋･その他南地区";
            rb9.Content = "北九州（小倉・門司）";
            rb10.Content = "北九州（八幡・黒崎・折尾）";
            rb11.Content = "大村市・諫早市";

            rb12.Content = "久留米";
            rb13.Content = "福岡県その他";
            rb14.Content = "松原市･藤井寺市･富田林･南河内";
            rb15.Content = "江坂・西中島・新大阪・十三";
            rb16.Content = "東大阪市・八尾市・平野・大東市";
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "大分市";
            rb2.Content = "湯布院・由布市";
            rb3.Content = "大分県その他";
            rb4.Content = "別府";
            rb5.Content = "中津市";

            rb6.Content = "大名・今泉・警固";
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "熊本市(上通り･下通り･新市街)";
            rb2.Content = "熊本市郊外";
            rb3.Content = "八代";
            rb4.Content = "阿蘇";
            rb5.Content = "天草・熊本県その他";

            rb6.Content = "大名・今泉・警固";
        }

        private void btMiyazaki_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "都城市";
            rb2.Content = "宮崎県その他";
            rb3.Content = "宮崎市郊外";
            rb4.Content = "日南市";
            rb5.Content = "延岡市・日向市";

            rb6.Content = "大名・今泉・警固";
        }

        private void btKagoshima_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "鹿児島市　天文館・中央駅・ふ頭";
            rb2.Content = "鹿児島県その他";
            rb3.Content = "騎射場・与次郎";
            rb4.Content = "谷山・宇宿";
            rb5.Content = "鹿児島市その他";
            rb6.Content = "奄美・屋久島";
            rb7.Content = "霧島市";

            rb8.Content = "大橋･その他南地区";
            rb9.Content = "北九州（小倉・門司）";
            rb10.Content = "北九州（八幡・黒崎・折尾）";
            rb11.Content = "飯塚・筑紫野";
        }

        private void btYamanashi_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "笛吹市";
            rb2.Content = "富士吉田・河口湖";
            rb3.Content = "北杜市";
            rb4.Content = "山梨県その他";
            rb5.Content = "甲府";
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "安曇野";
            rb2.Content = "諏訪・茅野諏訪・茅野";
            rb3.Content = "長野県その他";
            rb4.Content = "長野市";
            rb5.Content = "松本市";
            rb6.Content = "軽井沢";
            rb7.Content = "上田・佐久";
        }

        private void btGihu_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "岐阜駅周辺・柳ヶ瀬・市役所";
            rb2.Content = "島・則武・正木・長良";
            rb3.Content = "県庁～岐南・柳津・岐阜駅以南";
            rb4.Content = "穂積・北方・大垣";
            rb5.Content = "日野・芥見・各務原";
            rb6.Content = "高山・中津川";
            rb7.Content = "多治見・土岐";
            rb8.Content = "下呂・岐阜県その他";

            rb9.Content = "佐渡・新潟県その他";
            rb10.Content = "亀田・新津エリア";
            rb11.Content = "長岡";
        }

        private void btHukui_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "小浜・福井県その他";
            rb2.Content = "福井市";
            rb3.Content = "敦賀";
            rb4.Content = "坂井市";

            rb5.Content = "日野・芥見・各務原";
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "新潟駅・万代";
            rb2.Content = "新潟駅南";
            rb3.Content = "古町周辺";
            rb4.Content = "新潟東区・北区エリア";
            rb5.Content = "新潟西エリア";
            rb6.Content = "出来島･女池･桜木･鳥屋野潟周辺";
            rb7.Content = "上越";
            rb8.Content = "新発田";
            rb9.Content = "佐渡・新潟県その他";
            rb10.Content = "亀田・新津エリア";
            rb11.Content = "燕三条";

            rb12.Content = "茨木";
            rb13.Content = "泉大津･岸和田･泉佐野･りんくう";
            rb14.Content = "松原市･藤井寺市･富田林･南河内";
            rb15.Content = "江坂・西中島・新大阪・十三";
            rb16.Content = "東大阪市・八尾市・平野・大東市";
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "黒部・富山県その他";
            rb2.Content = "富山市";
            rb3.Content = "高岡";

            rb4.Content = "新潟東区・北区エリア";
            rb5.Content = "新潟西エリア";
            rb6.Content = "出来島･女池･桜木･鳥屋野潟周辺";
            rb7.Content = "上越";
            rb8.Content = "新発田";
            rb9.Content = "佐渡・新潟県その他";
            rb10.Content = "亀田・新津エリア";
            rb11.Content = "長岡";
        }

        private void btIbaraki_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "結城市";
            rb2.Content = "水戸";
            rb3.Content = "つくば";
            rb4.Content = "日立・ひたちなか";
            rb5.Content = "笠間・常陸太田・茨城県北部他";
            rb6.Content = "鹿嶋・鉾田・茨城県南部他";
            rb7.Content = "土浦";

            rb8.Content = "新発田";
            rb9.Content = "佐渡・新潟県その他";
            rb10.Content = "亀田・新津エリア";
            rb11.Content = "長岡";

        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "金沢(片町･香林坊･にし茶屋周辺)";
            rb2.Content = "金沢(金沢駅･近江町･ひがし茶屋)";
            rb3.Content = "金沢市他・野々市・白山・内灘";

            rb4.Content = "新潟東区・北区エリア";
            rb5.Content = "新潟西エリア";
            rb6.Content = "出来島･女池･桜木･鳥屋野潟周辺";
            rb7.Content = "上越";
            rb8.Content = "新発田";
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "桐生市・みどり市";
            rb2.Content = "館林・大泉町・邑楽町";
            rb3.Content = "前橋";
            rb4.Content = "草津・嬬恋";
            rb5.Content = "伊香保・群馬県その他";
            rb6.Content = "高崎";
            rb7.Content = "伊勢崎・玉村";
            rb8.Content = "太田市";
        }

        private void btAomori_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "青森市";
            rb2.Content = "弘前";
            rb3.Content = "八戸";
            rb4.Content = "五所川原・青森西部";
            rb5.Content = "十和田・三沢・おいらせ町";
            rb6.Content = "むつ市・青森東部";

            rb7.Content = "上越";
            rb8.Content = "新発田";
        }

        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "秋田市";
            rb2.Content = "仙北市・秋田県北部";
            rb3.Content = "横手・秋田県南部";

            rb4.Content = "五所川原・青森西部";
            rb5.Content = "十和田・三沢・おいらせ町";
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "山形市";
            rb2.Content = "米沢";
            rb3.Content = "酒田・鶴岡";
            rb4.Content = "山形県その他";

            rb5.Content = "十和田・三沢・おいらせ町";
        }

        private void btSaga_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "佐賀市";
            rb2.Content = "佐賀県その他";
            rb3.Content = "唐津";

            rb4.Content = "山形県その他";
        }

        private void btOkinawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.Content = "那覇";
            rb2.Content = "糸満・豊見城・南風原・南城";
            rb3.Content = "石垣島・宮古島・沖縄離島";
            rb4.Content = "名護・恩納村・本部町";
            rb5.Content = "読谷･北谷･宜野湾･浦添･嘉手納";
            rb6.Content = "沖縄市・うるま・西原・北中城";

            rb7.Content = "上越";
            rb8.Content = "新発田";


        }
    }
}
