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

            rbCheckOff();

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
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
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
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
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
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
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
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list.AddRange(area);
        }

        private void btHokkaido_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "すすきの","室蘭・登別・白老","富良野・その他北海道","札幌（札幌駅・大通）","札幌（札幌駅・大通）","麻生・北24条（北区・東区）",
                                          "南郷・新札幌　白石・厚別・清田","琴似・円山公園　中央・西・手稲","平岸・澄川（豊平区・南区）","旭川", "函館",
                                          "小樽・千歳・苫小牧・札幌近郊","帯広・釧路・北見・河東郡",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "北海道";

            rbArray();

        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1,rb2,rb3,rb4,rb5,rb6,rb7,rb8,rb9,rb10, rb11,rb12,rb13,rb14,rb15,rb16,rb17,rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,
                                           rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                          };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "銀座・有楽町・新橋・築地・月島","水道橋・飯田橋・神楽坂","お台場","東京・大手町・日本橋・人形町",
                                          "四ツ谷・麹町・市ヶ谷・九段下","上野・御徒町・浅草","北千住・日暮里・葛飾・荒川","錦糸町・浅草橋・両国・亀戸",
                                          "門前仲町・東陽町・木場・葛西","神田・神保町・秋葉原・御茶ノ水", "品川･目黒･田町･浜松町･五反田","蒲田・大森・大田区","渋谷",
                                          "原宿・青山・表参道","恵比寿・中目黒・代官山・広尾","赤坂・六本木・麻布十番・西麻布","自由が丘・田園調布","池袋","赤羽・王子・十条",
                                          "新宿","新大久保・大久保","巣鴨・大塚・駒込","中野・高円寺・阿佐ヶ谷・方南町","下北沢・代々木上原","高田馬場",
                                          "池尻大橋・三軒茶屋・駒沢大学","桜新町・用賀・二子玉川","祐天寺・学芸大学・都立大学","幡ヶ谷・笹塚・明大前・下高井戸",
                                          "調布・府中・千歳烏山・仙川","経堂・千歳船橋","祖師ヶ谷大蔵・成城学園前","大井町･中延･旗の台･戸越･馬込","不動前・武蔵小山",
                                          "雪が谷大塚・池上","武蔵小金井","国立・国分寺","青梅・昭島・小作・青梅線沿線","多摩センター・南大沢","吉祥寺・荻窪・三鷹",
                                          "町田","八王子・立川","西武池袋線（石神井公園～秋津）","西武新宿線(中井～田無～東村山)","練馬・板橋・成増・江古田",
                                          "都営三田線（新板橋～西高島平）","聖蹟桜ヶ丘・高幡不動・分倍河原","東京都その他",
                                        };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            decide.Content = "東京都";
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "武蔵小杉・元住吉・新丸子", "新横浜・綱島・菊名・鴨居", "大和・中央林間・長津田",
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
            var area2 = new RadioButton[] { rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "神奈川県";
        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12};
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "千葉・稲毛", "船橋･津田沼･市川･本八幡･中山", "南房総・館山", "柏・南柏・我孫子",
                                        "舞浜・浦安・行徳・妙典下", "成田・佐倉", "海浜幕張", "蘇我・鎌取・茂原", "松戸・新松戸", "銚子・旭",
                                        "木更津・市原", "千葉県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "千葉県";
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "大宮・さいたま新都心", "川口・西川口・蕨", "浦和・武蔵浦和", "熊谷・深谷・本庄",
                                        "東松山・坂戸", "秩父", "戸田", "上尾・北上尾・蓮田", "所沢", "西武新宿線（航空公園～南大塚）",
                                        "東武東上線 和光市～新河岸･新座", "西武池袋線（小手指～飯能）", "川越", "春日部・越谷・草加・三郷", "埼玉県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "埼玉県";
        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "名古屋（名古屋駅/西区/中村区）", "栄ｷﾀ錦/伏見丸の内/泉/東桜/新栄", "栄(ミナミ)/矢場町/大須/上前津",
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
            var area2 = new RadioButton[] { rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "愛知県";
        }

        private void btShizuoka_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "静岡駅周辺・葵区・駿河区", "清水駅周辺～草薙", "浜松", "伊豆・伊東・下田",
                                         "焼津・藤枝・掛川", "熱海", "富士宮", "御殿場・富士・沼津・三島", "静岡県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "静岡県";
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOff();

            allClear();

            decide.Content = "鳥取県";
        }

        private void btShimane_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOff();

            allClear();

            decide.Content = "島根県";
        }

        private void btShiga_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "草津市・守山市", "大津", "長浜市・彦根市", "近江八幡市・東近江市", "滋賀県その他",
                                         };
            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb6, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "滋賀県";
        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "伊勢", "松阪", "四日市", "津", "鈴鹿", "鳥羽・志摩",};

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "三重県";
        }

        private void btNara_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "奈良市", "天理市・橿原市", "大和郡山市・生駒市", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb4, rb5, rb6, rb7, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18,rb19,rb20,rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "奈良県";
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb7, rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "梅田", "福島・野田", "淀屋橋・本町・北浜・天満橋", "京橋・天満・天六・南森町",
                                        "心斎橋・なんば・南船場・堀江", "天王寺", "上本町・鶴橋", "針中野･長居･西田辺･西成区･住吉",
                                        "関目・千林・緑橋・深江橋", "堺・高石市・和泉市", "高槻", "茨木", "泉大津･岸和田･泉佐野･りんくう",
                                        "松原市･藤井寺市･富田林･南河内", "江坂・西中島・新大阪・十三", "東大阪市・八尾市・平野・大東市",
                                        "九条･西九条･弁天町･大正･住之江", "枚方・寝屋川・守口・門真", "箕面・池田", "大阪府その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] { rb21,rb22,rb23,rb24,rb25,rb26,rb27,rb28,rb29,rb30,
                                           rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            decide.Content = "大阪府";
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            var list1 = new List<RadioButton>();
            var area1 = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb7, };
            list1.AddRange(area1);

            var list2 = new List<string>();
            var areaName = new string[] { "烏丸御池・四条烏丸", "左京区・山科区", "北区・上京区", "河原町・木屋町",
                                          "祇園・先斗町", "四条大宮・西院・右京区・西京区", "烏丸五条・京都駅周辺", "宮津・京丹後・京都府その他", };

            list2.AddRange(areaName);

            for (int i = 0; i < area1.Length; i++)
            {
                area1[i].Content = areaName[i];
            }

            var list3 = new List<RadioButton>();
            var area2 = new RadioButton[] {  rb8, rb9, rb10, rb11, rb12, rb13, rb14, rb15, rb16, rb17, rb18, rb19, rb20,rb21,rb22,rb23,rb24,rb25,
                                             rb26,rb27,rb28,rb29,rb30,rb31,rb32,rb33,rb34,rb35,rb36,rb37,rb38,rb39,rb40,rb41,rb42,rb43,rb44,rb45,rb46,rb47,rb48,
                                         };
            list3.AddRange(area2);

            for (int i = 0; i < area2.Length; i++)
            {
                area2[i].IsEnabled = false;
            }

            rb1.Content = "烏丸御池・四条烏丸";
            rb2.Content = "左京区・山科区";
            rb3.Content = "北区・上京区";
            rb4.Content = "河原町・木屋町";
            rb5.Content = "祇園・先斗町";
            rb6.Content = "四条大宮・西院・右京区・西京区";
            rb7.Content = "烏丸五条・京都駅周辺";
            rb8.Content = "宮津・京丹後・京都府その他";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "京都府";
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

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

            decide.Content = "兵庫県";
        }

        private void btWakayama_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "白浜・和歌山県その他";
            rb2.Content = "和歌山市";
            rb3.Content = "田辺市";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "和歌山県";
        }

        private void btIwate_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "宮古・岩手県その他";
            rb2.Content = "盛岡";
            rb3.Content = "花巻・北上・奥州・一関";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "岩手県";
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "仙台（仙台駅周辺）";
            rb2.Content = "宮城県その他";
            rb3.Content = "青葉・宮城野・若林";
            rb4.Content = "仙台（国分町・一番町周辺）";
            rb5.Content = "泉中央";
            rb6.Content = "長町";
            rb7.Content = "大崎市";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "宮城県";
        }

        private void btHukushima_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "郡山";
            rb2.Content = "会津若松";
            rb3.Content = "喜多方";
            rb4.Content = "福島市";
            rb5.Content = "いわき・福島県その他";

            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "福島県";
        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "宇都宮";
            rb2.Content = "栃木県その他";
            rb3.Content = "日光・鹿沼";
            rb4.Content = "那須・塩原";
            rb5.Content = "小山市・栃木市";
            rb6.Content = "足利市・佐野市";

            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "栃木県";
        }

        private void btHiroshima_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "広島市（広島市中心部）";
            rb2.Content = "広島駅・横川・その他広島市内";
            rb3.Content = "福山";
            rb4.Content = "尾道";
            rb5.Content = "呉";
            rb6.Content = "広島県その他";

            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "広島県";
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "岡山市";
            rb2.Content = "倉敷（倉敷市中心部）";
            rb3.Content = "倉敷(倉敷市郊外･児島･水島など)";
            rb4.Content = "備前・岡山県その他";

            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "岡山県";
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "萩・山口県その他";
            rb2.Content = "下関";
            rb3.Content = "山口市";
            rb4.Content = "宇部市";
            rb5.Content = "周南市・下松市";
            rb6.Content = "岩国";
            rb7.Content = "防府";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "山口県";

        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "高松市中心部";
            rb2.Content = "高松市郊外";
            rb3.Content = "坂出・香川県その他";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "香川県";
        }

        private void btTokushima_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "徳島市・徳島市周辺部";
            rb2.Content = "高松市郊外";
            rb3.Content = "徳島県その他";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "徳島県";
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "松山";
            rb2.Content = "今治";
            rb3.Content = "宇和島･東予･南予･愛媛県その他";
            rb4.Content = "新居浜・西条";

            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "愛媛県";
        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOff();

            allClear();

            decide.Content = "高知県";
        }

        private void btHukuoka_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

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

            decide.Content = "福岡県";
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

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

            decide.Content = "長崎県";
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "大分市";
            rb2.Content = "湯布院・由布市";
            rb3.Content = "大分県その他";
            rb4.Content = "別府";
            rb5.Content = "中津市";

            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "大分県";
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "熊本市(上通り･下通り･新市街)";
            rb2.Content = "熊本市郊外";
            rb3.Content = "八代";
            rb4.Content = "阿蘇";
            rb5.Content = "天草・熊本県その他";

            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "熊本県";
        }

        private void btMiyazaki_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "都城市";
            rb2.Content = "宮崎県その他";
            rb3.Content = "宮崎市郊外";
            rb4.Content = "日南市";
            rb5.Content = "延岡市・日向市";

            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "宮崎県";
        }

        private void btKagoshima_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "鹿児島市　天文館・中央駅・ふ頭";
            rb2.Content = "鹿児島県その他";
            rb3.Content = "騎射場・与次郎";
            rb4.Content = "谷山・宇宿";
            rb5.Content = "鹿児島市その他";
            rb6.Content = "奄美・屋久島";
            rb7.Content = "霧島市";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "鹿児島県";
        }

        private void btYamanashi_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "笛吹市";
            rb2.Content = "富士吉田・河口湖";
            rb3.Content = "北杜市";
            rb4.Content = "山梨県その他";
            rb5.Content = "甲府";

            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "山梨県";
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "安曇野";
            rb2.Content = "諏訪・茅野諏訪・茅野";
            rb3.Content = "長野県その他";
            rb4.Content = "長野市";
            rb5.Content = "松本市";
            rb6.Content = "軽井沢";
            rb7.Content = "上田・佐久";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "長野県";
        }

        private void btGihu_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "岐阜駅周辺・柳ヶ瀬・市役所";
            rb2.Content = "島・則武・正木・長良";
            rb3.Content = "県庁～岐南・柳津・岐阜駅以南";
            rb4.Content = "穂積・北方・大垣";
            rb5.Content = "日野・芥見・各務原";
            rb6.Content = "高山・中津川";
            rb7.Content = "多治見・土岐";
            rb8.Content = "下呂・岐阜県その他";

            rb9.IsEnabled = false;
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

            decide.Content = "岐阜県";
        }

        private void btHukui_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "小浜・福井県その他";
            rb2.Content = "福井市";
            rb3.Content = "敦賀";
            rb4.Content = "坂井市";

            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "福井県";
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

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

            decide.Content = "新潟県";
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "黒部・富山県その他";
            rb2.Content = "富山市";
            rb3.Content = "高岡";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "富山県";
        }

        private void btIbaragi_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "結城市";
            rb2.Content = "水戸";
            rb3.Content = "つくば";
            rb4.Content = "日立・ひたちなか";
            rb5.Content = "笠間・常陸太田・茨城県北部他";
            rb6.Content = "鹿嶋・鉾田・茨城県南部他";
            rb7.Content = "土浦";

            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "茨城県";

        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "金沢(片町･香林坊･にし茶屋周辺)";
            rb2.Content = "金沢(金沢駅･近江町･ひがし茶屋)";
            rb3.Content = "金沢市他・野々市・白山・内灘";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "石川県";
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "桐生市・みどり市";
            rb2.Content = "館林・大泉町・邑楽町";
            rb3.Content = "前橋";
            rb4.Content = "草津・嬬恋";
            rb5.Content = "伊香保・群馬県その他";
            rb6.Content = "高崎";
            rb7.Content = "伊勢崎・玉村";
            rb8.Content = "太田市";

            rb9.IsEnabled = false;
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

            decide.Content = "群馬県";
        }

        private void btAomori_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "青森市";
            rb2.Content = "弘前";
            rb3.Content = "八戸";
            rb4.Content = "五所川原・青森西部";
            rb5.Content = "十和田・三沢・おいらせ町";
            rb6.Content = "むつ市・青森東部";

            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "青森県";
        }

        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "秋田市";
            rb2.Content = "仙北市・秋田県北部";
            rb3.Content = "横手・秋田県南部";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "秋田県";
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "山形市";
            rb2.Content = "米沢";
            rb3.Content = "酒田・鶴岡";
            rb4.Content = "山形県その他";

            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "山形県";
        }

        private void btSaga_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "佐賀市";
            rb2.Content = "佐賀県その他";
            rb3.Content = "唐津";

            rb4.IsEnabled = false;
            rb5.IsEnabled = false;
            rb6.IsEnabled = false;
            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "佐賀県";
        }

        private void btOkinawa_Click(object sender, RoutedEventArgs e)
        {
            rbCheckOn();

            allClear();

            rb1.Content = "那覇";
            rb2.Content = "糸満・豊見城・南風原・南城";
            rb3.Content = "石垣島・宮古島・沖縄離島";
            rb4.Content = "名護・恩納村・本部町";
            rb5.Content = "読谷･北谷･宜野湾･浦添･嘉手納";
            rb6.Content = "沖縄市・うるま・西原・北中城";

            rb7.IsEnabled = false;
            rb8.IsEnabled = false;
            rb9.IsEnabled = false;
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

            decide.Content = "沖縄県";
        }
    }
}
