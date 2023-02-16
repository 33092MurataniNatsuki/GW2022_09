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

        //親ウィンドウのインスタンスを取得
        Window1 parent = (Window1)Application.Current.MainWindow;

        public Area() {
            InitializeComponent();

            rbCheckOff();

            rb1.Content = "指定なし";

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

        private void rbCheckOn()
        {
            var list = new List<RadioButton>();
            var area = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list.AddRange(area);

            for (int i = 0; i < area.Length; i++)
            {
                area[i].IsEnabled = true;
            }
        }

        private void rbCheckOff()
        {
            var list = new List<RadioButton>();
            var area = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list.AddRange(area);

            for (int i = 0; i < area.Length; i++)
            {
                area[i].IsEnabled = false;
            }
        }

        private void allClear()
        {
            var list = new List<RadioButton>();
            var area = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list.AddRange(area);

            for (int i = 0; i < area.Length; i++)
            {
                area[i].Content = "";
            }
        }


        private void rbArray()
        {
            var list = new List<RadioButton>();
            var area = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list.AddRange(area);
        }

        private void btHokkaido_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","すすきの","室蘭・登別・白老","富良野・その他北海道","札幌（札幌駅・大通）","麻生・北24条（北区・東区）",
                                          "南郷・新札幌　白石・厚別・清田","琴似・円山公園　中央・西・手稲","平岸・澄川（豊平区・南区）","旭川", "函館",
                                          "小樽・千歳・苫小牧・札幌近郊","帯広・釧路・北見・河東郡",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb13, rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            

            lbDecide.Content = "北海道";

            rbArray();

        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                          };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","銀座・有楽町・新橋・築地・月島","水道橋・飯田橋・神楽坂","お台場","東京・大手町・日本橋・人形町",
                                          "四ツ谷・麹町・市ヶ谷・九段下","上野・御徒町・浅草","北千住・日暮里・葛飾・荒川","錦糸町・浅草橋・両国・亀戸",
                                          "門前仲町・東陽町・木場・葛西","神田・神保町・秋葉原・御茶ノ水", "品川･目黒･田町･浜松町･五反田","蒲田・大森・大田区","渋谷",
                                          "原宿・青山・表参道","恵比寿・中目黒・代官山・広尾","赤坂・六本木・麻布十番・西麻布","自由が丘・田園調布","池袋","赤羽・王子・十条",
                                          "新宿","新大久保・大久保","巣鴨・大塚・駒込","中野・高円寺・阿佐ヶ谷・方南町","下北沢・代々木上原","高田馬場",
                                          "池尻大橋・三軒茶屋・駒沢大学","桜新町・用賀・二子玉川","幡ヶ谷・笹塚・明大前・下高井戸",
                                          "調布・府中・千歳烏山・仙川","経堂・千歳船橋","祖師ヶ谷大蔵・成城学園前","大井町･中延･旗の台･戸越･馬込","不動前・武蔵小山",
                                          "雪が谷大塚・池上","東京都その他",
                                        };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            lbDecide.Content = "東京都";

            
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","武蔵小杉・元住吉・新丸子", "新横浜・綱島・菊名・鴨居", "大和・中央林間・長津田",
                                        "新百合ヶ丘・登戸", "横浜", "桜木町みなとみらい･関内･中華街", "上大岡・杉田・新杉田・金沢文庫",
                                        "センター北・南、仲町台・都筑区", "川崎・鶴見", "本厚木･相模大野･海老名･伊勢原",
                                        "相模原・橋本・淵野辺", "大船・戸塚・東戸塚・保土ヶ谷", "藤沢・辻堂茅ヶ崎・平塚・湘南台",
                                        "鎌倉・江の島", "小田原・箱根・湯河原・真鶴", "横須賀中央・三浦・久里浜・汐入", "逗子・葉山",
                                        "神奈川県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "神奈川県";
        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12,rb13};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","千葉・稲毛", "船橋･津田沼･市川･本八幡･中山", "南房総・館山", "柏・南柏・我孫子",
                                        "舞浜・浦安・行徳・妙典下", "成田・佐倉", "海浜幕張", "蘇我・鎌取・茂原", "松戸・新松戸", "銚子・旭",
                                        "木更津・市原", "千葉県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "千葉県";
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","大宮・さいたま新都心", "川口・西川口・蕨", "浦和・武蔵浦和", "熊谷・深谷・本庄",
                                        "東松山・坂戸", "秩父", "戸田", "上尾・北上尾・蓮田", "所沢", "西武新宿線（航空公園～南大塚）",
                                        "東武東上線 和光市～新河岸･新座", "西武池袋線（小手指～飯能）", "川越", "春日部・越谷・草加・三郷", "埼玉県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "埼玉県";
        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","名古屋（名古屋駅/西区/中村区）", "栄ｷﾀ錦/伏見丸の内/泉/東桜/新栄", "栄(ミナミ)/矢場町/大須/上前津",
                                        "金山・神宮前・熱田区", "鶴舞・八事・御器所", "大曽根･千種･今池･池下･守山区", "緑区・南区・天白区・瑞穂区",
                                        "本山・覚王山・藤が丘", "豊田市", "中川区・港区", "名古屋市その他", "安城・刈谷・岡崎・知立・蒲郡",
                                        "豊橋・豊川", "半田・知多・碧南・西尾", "春日井・小牧・一宮・江南・瀬戸", "愛知県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "愛知県";
        }

        private void btShizuoka_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] {"指定なし", "静岡駅周辺・葵区・駿河区", "清水駅周辺～草薙", "浜松", "伊豆・伊東・下田",
                                         "焼津・藤枝・掛川", "熱海", "富士宮", "御殿場・富士・沼津・三島", "静岡県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "静岡県";
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOff();

            allClear();

            lbDecide.Content = "鳥取県";
        }

        private void btShimane_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOff();

            allClear();

            lbDecide.Content = "島根県";
        }

        private void btShiga_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","草津市・守山市", "大津", "長浜市・彦根市", "近江八幡市・東近江市", "滋賀県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "滋賀県";
        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "伊勢", "桑名", "松阪", "四日市", "津", "鈴鹿", "鳥羽・志摩","三重県その他"};

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "三重県";
        }

        private void btNara_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOff();

            allClear();

            lbDecide.Content = "奈良県";
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20, rb21, rb22, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","梅田", "福島・野田", "淀屋橋・本町・北浜・天満橋", "京橋・天満・天六・南森町",
                                        "心斎橋・なんば・南船場・堀江", "天王寺", "上本町・鶴橋", "針中野･長居･西田辺･西成区･住吉","大阪市その他",
                                        "関目・千林・緑橋・深江橋", "堺・高石市・和泉市", "高槻", "茨木", "泉大津･岸和田･泉佐野･りんくう",
                                        "松原市･藤井寺市･富田林･南河内", "江坂・西中島・新大阪・十三", "東大阪市・八尾市・平野・大東市",
                                        "九条･西九条･弁天町･大正･住之江", "枚方・寝屋川・守口・門真", "箕面・池田", "大阪府その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "大阪府";
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","烏丸御池・四条烏丸", "左京区・山科区", "北区・上京区", "河原町・木屋町",
                                          "祇園・先斗町", "四条大宮・西院・右京区・西京区", "烏丸五条・京都駅周辺", "宮津・京丹後・京都府その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "京都府";
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","神戸", "明石", "灘・東灘", "須磨・垂水・西区・兵庫・長田", "姫路",
                                        "加古川", "淡路島", "西宮・芦屋・宝塚", "城崎・豊岡", "北区・有馬温泉・三田", "尼崎", "兵庫県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "兵庫県";
        }

        private void btWakayama_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし",  "和歌山市", "田辺市", "白浜・和歌山県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "和歌山県";
            Home home = new Home();
            home.check = 1;
        }

        private void btIwate_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "盛岡", "花巻・北上・奥州・一関", "宮古・岩手県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "岩手県";
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","仙台（仙台駅周辺）", "青葉・宮城野・若林", "仙台（国分町・一番町周辺）",
                                        "泉中央", "長町", "大崎市", "宮城県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "宮城県";
        }

        private void btHukushima_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "郡山", "会津若松", "喜多方", "福島市", "いわき・福島県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "福島県";
        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "宇都宮", "小山市・栃木市", "日光・鹿沼"," 那須・塩原,","足利市・佐野市", "栃木県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "栃木県";
        }

        private void btHiroshima_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] {"指定なし", "広島市（広島市中心部）", "広島駅・横川・その他広島市内", "福山",
                                        "尾道", "呉", "広島県その他",};

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "広島県";
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "岡山市", "倉敷（倉敷市中心部）", "倉敷(倉敷市郊外･児島･水島など)", "備前・岡山県その他",};

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "岡山県";
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "下関", "山口市", "宇部市", "周南市・下松市", "岩国", "防府", "萩・山口県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "山口県";

        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "丸亀･坂出･宇多津･善通寺･多度津", "高松市中心部", "高松市郊外", "坂出・香川県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "香川県";
        }

        private void btTokushima_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "徳島市・徳島市周辺部", "坂出・徳島県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "徳島県";
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "松山", "今治", "新居浜・西条", "宇和島･東予･南予･愛媛県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "愛媛県";
        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOff();

            allClear();

            lbDecide.Content = "高知県";
        }

        private void btHukuoka_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] {"指定なし", "博多", "中洲・中洲川端", "天神・西中洲・春吉", "西新・姪浜・その他西エリア",
                                          "吉塚・香椎・その他東エリア", "大名・今泉・警固", "薬院･平尾･高砂", "大橋･その他南地区",
                                          "北九州（小倉・門司）", "北九州（八幡・黒崎・折尾）", "飯塚・筑紫野", "久留米", "福岡県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "福岡県";
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "長崎市", "大村市・諫早市", "佐世保・長崎県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "長崎県";
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "大分市", "湯布院・由布市", "別府", "中津市", "大分県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "大分県";
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "熊本市(上通り･下通り･新市街)", "熊本市郊外", "八代", "阿蘇", "天草・熊本県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "熊本県";
        }

        private void btMiyazaki_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "都城市", "宮崎市郊外", "日南市", "延岡市・日向市", "宮崎県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "宮崎県";
        }

        private void btKagoshima_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","鹿児島市　天文館・中央駅・ふ頭", "騎射場・与次郎", "谷山・宇宿",
                                        "奄美・屋久島", "霧島市", "鹿児島県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {   rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "鹿児島県";
        }

        private void btYamanashi_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "笛吹市", "富士吉田・河口湖", "北杜市", "甲府", "山梨県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "山梨県";
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "安曇野", "諏訪・茅野", "長野市","松本市", "軽井沢", "上田・佐久", "長野県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "長野県";
        }

        private void btGihu_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","岐阜駅周辺・柳ヶ瀬・市役所", "島・則武・正木・長良", "県庁～岐南・柳津・岐阜駅以南",
                                        "穂積・北方・大垣", "日野・芥見・各務原", "高山・中津川", "多治見・土岐", "下呂・岐阜県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "岐阜県";
        }

        private void btHukui_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "福井市", "坂井市", "敦賀", "小浜・福井県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "福井県";
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","新潟駅・万代", "新潟駅南", "古町周辺", "新潟東区・北区エリア",
                                        "新潟西エリア", "出来島･女池･桜木･鳥屋野潟周辺", "上越", "新発田",
                                        "燕三条", "亀田・新津エリア", "佐渡・新潟県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "新潟県";
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "高岡", "富山市", "黒部・富山県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "富山県";
        }

        private void btIbaragi_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "結城市", "水戸", "つくば", "日立・ひたちなか", "土浦", "笠間・常陸太田・茨城県北部他", "鹿嶋・鉾田・茨城県南部他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "茨城県";

        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "金沢(片町･香林坊･にし茶屋周辺)", "金沢(金沢駅･近江町･ひがし茶屋)", "金沢市他・野々市・白山・内灘", "輪島・七尾・加賀・石川県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "石川県";
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","桐生市・みどり市", "館林・大泉町・邑楽町", "前橋", "草津・嬬恋",
                                        "高崎", "伊勢崎・玉村", "太田市", "伊香保・群馬県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "群馬県";
        }

        private void btAomori_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOff();

            allClear();

            lbDecide.Content = "青森県";
        }

        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "秋田市", "仙北市・秋田県北部", "横手・秋田県南部", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "秋田県";
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "山形市", "米沢", "酒田・鶴岡", "山形県その他",};

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "山形県";
        }

        private void btSaga_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし", "佐賀市", "唐津", "佐賀県その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "佐賀県";
        }

        private void btOkinawa_Click(object sender, RoutedEventArgs e)
        {
            rb1.IsChecked = true;

            lbWhite();

            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6 };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "指定なし","那覇", "糸満・豊見城・南風原・南城", "石垣島・宮古島・沖縄離島", "名護・恩納村・本部町",
                                        "読谷･北谷･宜野湾･浦添･嘉手納", "沖縄市・うるま・西原・北中城", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,
                                             rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            lbDecide.Content = "沖縄県";

            //parent.selectedPref = (string)lbDecide.Content;
            //parent.selectedArea = (string)lbDecideCb.Content;

            //var home = new Home();
            //NavigationService.Navigate(home);
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            lbWhite();

            RadioButton rb = (RadioButton)sender;
            lbDecideCb.Content = rb.Content;
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            //if (lbDecideCb.Content != rb1.Content)
            //{
            //    lbColor.Background = Brushes.GhostWhite;
            //    //lbColor.Background = Brushes.AliceBlue;
            //}
            //if (lbDecideCb.Content != rb2.Content)
            //{
            //    lbColor.Background = Brushes.GhostWhite;
            //    //lbColor.Background = Brushes.AliceBlue;
            //}

            parent.selectedPref = (string)lbDecide.Content;
            parent.selectedArea = (string)lbDecideCb.Content;

            var home = new Home();
            NavigationService.Navigate(home);
        }

        private void lbWhite()
        {
            lbColor.Background = Brushes.White;
        }
    }
}
