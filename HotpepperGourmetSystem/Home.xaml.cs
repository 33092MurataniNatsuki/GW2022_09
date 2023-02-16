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
using System.Drawing;
using System.Reflection;

namespace HotpepperGourmetSystem {
    /// <summary>
    /// Home.xaml の相互作用ロジック
    /// </summary>
    public partial class Home : Page {

        public int check;
        string largeAreaCode;
        string midleAreaCode;
        string genreCode;
        string budgetCode;


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
            cbBudgetMinMax.SelectedItem = parent.selectedBudget;

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
                    largeAreaCode = "Z016";
                    break;
                case "群馬県":
                    largeAreaCode = "Z017";
                    break;
                case "滋賀県":
                    largeAreaCode = "Z021";
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
                    largeAreaCode = "Z033";
                    break;
                case "三重県":
                    largeAreaCode = "Z034";
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
                case "四ツ谷・麹町・市ヶ谷・九段下":
                    midleAreaCode = "Y013";
                    break;
                case "上野・御徒町・浅草":
                    midleAreaCode = "Y015";
                    break;
                case "北千住・日暮里・葛飾・荒川":
                    midleAreaCode = "Y016";
                    break;
                case "錦糸町・浅草橋・両国・亀戸":
                    midleAreaCode = "Y017";
                    break;
                case "門前仲町・東陽町・木場・葛西":
                    midleAreaCode = "Y018";
                    break;
                case "神田・神保町・秋葉原・御茶ノ水":
                    midleAreaCode = "Y020";
                    break;
                case "品川･目黒･田町･浜松町･五反田":
                    midleAreaCode = "Y025";
                    break;
                case "蒲田・大森・大田区":
                    midleAreaCode = "Y026";
                    break;
                case "渋谷":
                    midleAreaCode = "Y030";
                    break;
                case "原宿・青山・表参道":
                    midleAreaCode = "Y035";
                    break;
                case "恵比寿・中目黒・代官山・広尾":
                    midleAreaCode = "Y040";
                    break;
                case "赤坂・六本木・麻布十番・西麻布":
                    midleAreaCode = "Y045";
                    break;
                case "自由が丘・田園調布":
                    midleAreaCode = "Y046";
                    break;
                case "池袋":
                    midleAreaCode = "Y050";
                    break;
                case "赤羽・王子・十条":
                    midleAreaCode = "Y051";
                    break;
                case "新宿":
                    midleAreaCode = "Y055";
                    break;
                case "新大久保・大久保":
                    midleAreaCode = "Y056";
                    break;
                case "巣鴨・大塚・駒込":
                    midleAreaCode = "Y057";
                    break;
                case "中野・高円寺・阿佐ヶ谷・方南町":
                    midleAreaCode = "Y060";
                    break;
                case "下北沢・代々木上原":
                    midleAreaCode = "Y070";
                    break;
                case "高田馬場":
                    midleAreaCode = "Y072";
                    break;
                case "池尻大橋・三軒茶屋・駒沢大学":
                    midleAreaCode = "Y073";
                    break;
                case "桜新町・用賀・二子玉川":
                    midleAreaCode = "Y074";
                    break;
                case "幡ヶ谷・笹塚・明大前・下高井戸":
                    midleAreaCode = "Y076";
                    break;
                case "調布・府中・千歳烏山・仙川":
                    midleAreaCode = "Y077";
                    break;
                case "経堂・千歳船橋":
                    midleAreaCode = "Y078";
                    break;
                case "祖師ヶ谷大蔵・成城学園前":
                    midleAreaCode = "Y079";
                    break;
                case "大井町･中延･旗の台･戸越･馬込":
                    midleAreaCode = "Y080";
                    break;
                case "不動前・武蔵小山":
                    midleAreaCode = "Y081";
                    break;
                case "雪が谷大塚・池上":
                    midleAreaCode = "Y082";
                    break;
                case "東京都その他":
                    midleAreaCode = "Y852";
                    break;
                case "すすきの":
                    midleAreaCode = "Y500";
                    break;
                case "室蘭・登別・白老":
                    midleAreaCode = "Y501";
                    break;
                case "富良野・その他北海道":
                    midleAreaCode = "Y502";
                    break;
                case "札幌（札幌駅・大通）":
                    midleAreaCode = "Y505";
                    break;
                case "麻生・北24条（北区・東区）":
                    midleAreaCode = "Y510";
                    break;
                case "南郷・新札幌 白石・厚別・清田":
                    midleAreaCode = "Y511";
                    break;
                case "琴似・円山公園 中央・西・手稲":
                    midleAreaCode = "Y512";
                    break;
                case "平岸・澄川（豊平区・南区）":
                    midleAreaCode = "Y513";
                    break;
                case "旭川":
                    midleAreaCode = "Y530";
                    break;
                case "函館":
                    midleAreaCode = "Y883";
                    break;
                case "小樽・千歳・苫小牧・札幌近郊":
                    midleAreaCode = "Y884";
                    break;
                case "帯広・釧路・北見・河東郡":
                    midleAreaCode = "Y885";
                    break;
                case "武蔵小杉・元住吉・新丸子":
                    midleAreaCode = "Y084";
                    break;
                case "新横浜・綱島・菊名・鴨居":
                    midleAreaCode = "Y085";
                    break;
                case "大和・中央林間・長津田":
                    midleAreaCode = "Y086";
                    break;
                case "新百合ヶ丘・登戸":
                    midleAreaCode = "Y087";
                    break;
                case "横浜":
                    midleAreaCode = "Y135";
                    break;
                case "桜木町みなとみらい･関内･中華街":
                    midleAreaCode = "Y136";
                    break;
                case "上大岡・杉田・新杉田・金沢文庫":
                    midleAreaCode = "Y138";
                    break;
                case "センター北・南、仲町台・都筑区":
                    midleAreaCode = "Y139";
                    break;
                case "川崎・鶴見":
                    midleAreaCode = "Y140";
                    break;
                case "本厚木･相模大野･海老名･伊勢原":
                    midleAreaCode = "Y141";
                    break;
                case "相模原・橋本・淵野辺":
                    midleAreaCode = "Y142";
                    break;
                case "大船・戸塚・東戸塚・保土ヶ谷":
                    midleAreaCode = "Y144";
                    break;
                case "藤沢・辻堂茅ヶ崎・平塚・湘南台":
                    midleAreaCode = "Y145";
                    break;
                case "鎌倉・江の島":
                    midleAreaCode = "Y853";
                    break;
                case "小田原・箱根・湯河原・真鶴":
                    midleAreaCode = "Y854";
                    break;
                case "横須賀中央・三浦・久里浜・汐入":
                    midleAreaCode = "Y855";
                    break;
                case "逗子・葉山":
                    midleAreaCode = "Y856";
                    break;
                case "神奈川県その他":
                    midleAreaCode = "Y857";
                    break;
                case "千葉・稲毛":
                    midleAreaCode = "Y115";
                    break;
                case "船橋･津田沼･市川･本八幡･中山":
                    midleAreaCode = "Y120";
                    break;
                case "南房総・館山":
                    midleAreaCode = "Y120";
                    break;
                case "柏・南柏・我孫子":
                    midleAreaCode = "Y125";
                    break;
                case "舞浜・浦安・行徳・妙典下":
                    midleAreaCode = "Y126";
                    break;
                case "成田・佐倉":
                    midleAreaCode = "Y127";
                    break;
                case "海浜幕張":
                    midleAreaCode = "Y128";
                    break;
                case "蘇我・鎌取・茂原":
                    midleAreaCode = "Y129";
                    break;
                case "松戸・新松戸":
                    midleAreaCode = "Y690";
                    break;
                case "銚子・旭":
                    midleAreaCode = "Y858";
                    break;
                case "木更津・市原":
                    midleAreaCode = "Y859";
                    break;
                case "千葉県その他":
                    midleAreaCode = "Y122";
                    break;
                case "大宮・さいたま新都心":
                    midleAreaCode = "Y130";
                    break;
                case "川口・西川口・蕨":
                    midleAreaCode = "Y131";
                    break;
                case "浦和・武蔵浦和":
                    midleAreaCode = "Y132";
                    break;
                case "熊谷・深谷・本庄":
                    midleAreaCode = "Y133";
                    break;
                case "東松山・坂戸":
                    midleAreaCode = "Y134";
                    break;
                case "秩父":
                    midleAreaCode = "Y160";
                    break;
                case "戸田":
                    midleAreaCode = "Y161";
                    break;
                case "上尾・北上尾・蓮田":
                    midleAreaCode = "Y162";
                    break;
                case "所沢":
                    midleAreaCode = "Y845";
                    break;
                case "西武新宿線（航空公園～南大塚）":
                    midleAreaCode = "Y846";
                    break;
                case "東武東上線 和光市～新河岸･新座":
                    midleAreaCode = "Y847";
                    break;
                case "西武池袋線（小手指～飯能）":
                    midleAreaCode = "Y860";
                    break;
                case "川越":
                    midleAreaCode = "Y861";
                    break;
                case "春日部・越谷・草加・三郷":
                    midleAreaCode = "Y862";
                    break;
                case "埼玉県その他":
                    midleAreaCode = "Y163";
                    break;
                case "名古屋（名古屋駅/西区/中村区）":
                    midleAreaCode = "Y200";
                    break;
                case "栄ｷﾀ錦/伏見丸の内/泉/東桜/新栄":
                    midleAreaCode = "Y205";
                    break;
                case "栄(ミナミ)/矢場町/大須/上前津":
                    midleAreaCode = "Y210";
                    break;
                case "金山・神宮前・熱田区":
                    midleAreaCode = "Y215";
                    break;
                case "鶴舞・八事・御器所":
                    midleAreaCode = "Y216";
                    break;
                case "大曽根･千種･今池･池下･守山区":
                    midleAreaCode = "Y220";
                    break;
                case "緑区・南区・天白区・瑞穂区":
                    midleAreaCode = "Y221";
                    break;
                case "本山・覚王山・藤が丘":
                    midleAreaCode = "Y222";
                    break;
                case "豊田市":
                    midleAreaCode = "Y223";
                    break;
                case "中川区・港区":
                    midleAreaCode = "Y224";
                    break;
                case "名古屋市その他":
                    midleAreaCode = "Y225";
                    break;
                case "安城・刈谷・岡崎・知立・蒲郡":
                    midleAreaCode = "Y875";
                    break;
                case "豊橋・豊川":
                    midleAreaCode = "Y994";
                    break;
                case "半田・知多・碧南・西尾":
                    midleAreaCode = "Y992";
                    break;
                case "春日井・小牧・一宮・江南・瀬戸":
                    midleAreaCode = "Y993";
                    break;
                case "愛知県その他":
                    midleAreaCode = "Y995";
                    break;
                case "静岡駅周辺・葵区・駿河区":
                    midleAreaCode = "Y230";
                    break;
                case "清水駅周辺～草薙":
                    midleAreaCode = "Y231";
                    break;
                case "浜松":
                    midleAreaCode = "Y800";
                    break;
                case "伊豆・伊東・下田":
                    midleAreaCode = "Y848";
                    break;
                case "焼津・藤枝・掛川":
                    midleAreaCode = "Y849";
                    break;
                case "熱海":
                    midleAreaCode = "Y876";
                    break;
                case "富士宮":
                    midleAreaCode = "Y877";
                    break;
                case "御殿場・富士・沼津・三島":
                    midleAreaCode = "Y997";
                    break;
                case "静岡県その他":
                    midleAreaCode = "Y878";
                    break;
                case "草津市・守山市":
                    midleAreaCode = "Y271";
                    break;
                case "大津":
                    midleAreaCode = "Y946";
                    break;
                case "長浜市・彦根市":
                    midleAreaCode = "Y947";
                    break;
                case "近江八幡市・東近江市":
                    midleAreaCode = "Y947";
                    break;
                case "滋賀県その他":
                    midleAreaCode = "Y270";
                    break;
                case "伊勢":
                    midleAreaCode = "Y943";
                    break;
                case "松阪":
                    midleAreaCode = "Y944";
                    break;
                case "桑名":
                    midleAreaCode = "Y945";
                    break;
                case "四日市":
                    midleAreaCode = "Y971";
                    break;
                case "津":
                    midleAreaCode = "Y989";
                    break;
                case "鈴鹿":
                    midleAreaCode = "Y990";
                    break;
                case "鳥羽・志摩":
                    midleAreaCode = "Y991";
                    break;
                case "三重県その他":
                    midleAreaCode = "Y280";
                    break;
                case "梅田":
                    midleAreaCode = "Y300";
                    break;
                case "福島・野田":
                    midleAreaCode = "Y301";
                    break;
                case "淀屋橋・本町・北浜・天満橋":
                    midleAreaCode = "Y305";
                    break;
                case "京橋・天満・天六・南森町":
                    midleAreaCode = "Y310";
                    break;
                case "心斎橋・なんば・南船場・堀江":
                    midleAreaCode = "Y315";
                    break;
                case "天王寺":
                    midleAreaCode = "Y325";
                    break;
                case "上本町・鶴橋":
                    midleAreaCode = "Y326";
                    break;
                case "針中野･長居･西田辺･西成区･住吉":
                    midleAreaCode = "Y327";
                    break;
                case "関目・千林・緑橋・深江橋":
                    midleAreaCode = "Y328";
                    break;
                case "大阪市その他":
                    midleAreaCode = "Y329";
                    break;
                case "堺・高石市・和泉市":
                    midleAreaCode = "Y350";
                    break;
                case "高槻":
                    midleAreaCode = "Y355";
                    break;
                case "茨木":
                    midleAreaCode = "Y356";
                    break;
                case "泉大津･岸和田･泉佐野･りんくう":
                    midleAreaCode = "Y357";
                    break;
                case "松原市･藤井寺市･富田林･南河内":
                    midleAreaCode = "Y358";
                    break;
                case "江坂・西中島・新大阪・十三":
                    midleAreaCode = "Y360";
                    break;
                case "東大阪市・八尾市・平野・大東市":
                    midleAreaCode = "Y361";
                    break;
                case "九条･西九条･弁天町･大正･住之江":
                    midleAreaCode = "Y866";
                    break;
                case "枚方・寝屋川・守口・門真":
                    midleAreaCode = "Y867";
                    break;
                case "箕面・池田":
                    midleAreaCode = "Y998";
                    break;
                case "大阪府その他":
                    midleAreaCode = "Y868";
                    break;
                case "烏丸御池・四条烏丸":
                    midleAreaCode = "Y365";
                    break;
                case "左京区・山科区":
                    midleAreaCode = "Y430";
                    break;
                case "北区・上京区":
                    midleAreaCode = "Y431";
                    break;
                case "河原町・木屋町":
                    midleAreaCode = "Y432";
                    break;
                case "祇園・先斗町":
                    midleAreaCode = "Y433";
                    break;
                case "四条大宮・西院・右京区・西京区":
                    midleAreaCode = "Y434";
                    break;
                case "烏丸五条・京都駅周辺":
                    midleAreaCode = "Y435";
                    break;
                case "宮津・京丹後・京都府その他":
                    midleAreaCode = "Y869";
                    break;
                case "神戸":
                    midleAreaCode = "Y370";
                    break;
                case "明石":
                    midleAreaCode = "Y371";
                    break;
                case "灘・東灘":
                    midleAreaCode = "Y372";
                    break;
                case "須磨・垂水・西区・兵庫・長田":
                    midleAreaCode = "Y373";
                    break;
                case "姫路":
                    midleAreaCode = "Y850";
                    break;
                case "加古川":
                    midleAreaCode = "Y851";
                    break;
                case "淡路島":
                    midleAreaCode = "Y870";
                    break;
                case "西宮・芦屋・宝塚":
                    midleAreaCode = "Y871";
                    break;
                case "城崎・豊岡":
                    midleAreaCode = "Y872";
                    break;
                case "北区・有馬温泉・三田":
                    midleAreaCode = "Y873";
                    break;
                case "尼崎":
                    midleAreaCode = "Y874";
                    break;
                case "兵庫県その他":
                    midleAreaCode = "Y996";
                    break;
                case "和歌山市":
                    midleAreaCode = "Y951";
                    break;
                case "田辺市":
                    midleAreaCode = "Y952";
                    break;
                case "白浜・和歌山県その他":
                    midleAreaCode = "Y400";
                    break;
                case "盛岡":
                    midleAreaCode = "Y915";
                    break;
                case "花巻・北上・奥州・一関":
                    midleAreaCode = "Y916";
                    break;
                case "宮古・岩手県その他":
                    midleAreaCode = "Y540";
                    break;
                case "仙台（仙台駅周辺）":
                    midleAreaCode = "Y550";
                    break;
                case "青葉・宮城野・若林":
                    midleAreaCode = "Y555";
                    break;
                case "仙台（国分町・一番町周辺）":
                    midleAreaCode = "Y886";
                    break;
                case "泉中央":
                    midleAreaCode = "Y887";
                    break;
                case "長町":
                    midleAreaCode = "Y888";
                    break;
                case "大崎市":
                    midleAreaCode = "Y889";
                    break;
                case "宮城県その他":
                    midleAreaCode = "Y554";
                    break;
                case "郡山":
                    midleAreaCode = "Y570";
                    break;
                case "会津若松":
                    midleAreaCode = "Y890";
                    break;
                case "喜多方":
                    midleAreaCode = "Y891";
                    break;
                case "福島市":
                    midleAreaCode = "Y892";
                    break;
                case "いわき・福島県その他":
                    midleAreaCode = "Y893";
                    break;
                case "宇都宮":
                    midleAreaCode = "Y580";
                    break;
                case "小山市・栃木市":
                    midleAreaCode = "Y865";
                    break;
                case "日光・鹿沼":
                    midleAreaCode = "Y863";
                    break;
                case "那須・塩原":
                    midleAreaCode = "Y864";
                    break;
                case "足利市・佐野市":
                    midleAreaCode = "Y979";
                    break;
                case "栃木県その他":
                    midleAreaCode = "Y581";
                    break;
                case "広島市（広島市中心部）":
                    midleAreaCode = "Y600";
                    break;
                case "広島駅・横川・その他広島市内":
                    midleAreaCode = "Y605";
                    break;
                case "福山":
                    midleAreaCode = "Y620";
                    break;
                case "尾道":
                    midleAreaCode = "Y894";
                    break;
                case "呉":
                    midleAreaCode = "Y986";
                    break;
                case "広島県その他":
                    midleAreaCode = "Y987";
                    break;
                case "岡山市":
                    midleAreaCode = "Y610";
                    break;
                case "倉敷（倉敷市中心部）":
                    midleAreaCode = "Y611";
                    break;
                case "倉敷(倉敷市郊外･児島･水島など)":
                    midleAreaCode = "Y612";
                    break;
                case "備前・岡山県その他":
                    midleAreaCode = "Y895";
                    break;
                case "下関":
                    midleAreaCode = "Y957";
                    break;
                case "山口市":
                    midleAreaCode = "Y958";
                    break;
                case "宇部市":
                    midleAreaCode = "Y982";
                    break;
                case "周南市・下松市":
                    midleAreaCode = "Y983";
                    break;
                case "岩国":
                    midleAreaCode = "Y984";
                    break;
                case "防府":
                    midleAreaCode = "Y985";
                    break;
                case "萩・山口県その他":
                    midleAreaCode = "Y640";
                    break;
                case "高松市中心部":
                    midleAreaCode = "Y650";
                    break;
                case "高松市郊外":
                    midleAreaCode = "Y652";
                    break;
                case "丸亀･坂出･宇多津･善通寺･多度津":
                    midleAreaCode = "Y896";
                    break;
                case "坂出・香川県その他":
                    midleAreaCode = "Y981";
                    break;
                case "徳島市・徳島市周辺部":
                    midleAreaCode = "Y660";
                    break;
                case "坂出・徳島県その他":
                    midleAreaCode = "Y897";
                    break;
                case "松山":
                    midleAreaCode = "Y670";
                    break;
                case "今治":
                    midleAreaCode = "Y898";
                    break;
                case "新居浜・西条":
                    midleAreaCode = "Y980";
                    break;
                case "宇和島･東予･南予･愛媛県その他":
                    midleAreaCode = "Y975";
                    break;
                case "博多":
                    midleAreaCode = "Y700";
                    break;
                case "中洲・中洲川端":
                    midleAreaCode = "Y705";
                    break;
                case "天神・西中洲・春吉":
                    midleAreaCode = "Y706";
                    break;
                case "西新・姪浜・その他西エリア":
                    midleAreaCode = "Y710";
                    break;
                case "吉塚・香椎・その他東エリア":
                    midleAreaCode = "Y711";
                    break;
                case "大名・今泉・警固":
                    midleAreaCode = "Y712";
                    break;
                case "薬院･平尾･高砂":
                    midleAreaCode = "Y713";
                    break;
                case "大橋･その他南地区":
                    midleAreaCode = "Y714";
                    break;
                case "北九州（小倉・門司）":
                    midleAreaCode = "Y730";
                    break;
                case "北九州（八幡・黒崎・折尾）":
                    midleAreaCode = "Y731";
                    break;
                case "飯塚・筑紫野":
                    midleAreaCode = "Y732";
                    break;
                case "久留米":
                    midleAreaCode = "Y900";
                    break;
                case "福岡県その他":
                    midleAreaCode = "Y901";
                    break;
                case "長崎市":
                    midleAreaCode = "Y740";
                    break;
                case "大村市・諫早市":
                    midleAreaCode = "Y902";
                    break;
                case "佐世保・長崎県その他":
                    midleAreaCode = "Y741";
                    break;
                case "大分市":
                    midleAreaCode = "Y750";
                    break;
                case "湯布院・由布市":
                    midleAreaCode = "Y751";
                    break;
                case "別府":
                    midleAreaCode = "Y903";
                    break;
                case "中津市":
                    midleAreaCode = "Y904";
                    break;
                case "大分県その他":
                    midleAreaCode = "Y752";
                    break;
                case "熊本市(上通り･下通り･新市街)":
                    midleAreaCode = "Y760";
                    break;
                case "熊本市郊外":
                    midleAreaCode = "Y762";
                    break;
                case "八代":
                    midleAreaCode = "Y763";
                    break;
                case "阿蘇":
                    midleAreaCode = "Y905";
                    break;
                case "天草・熊本県その他":
                    midleAreaCode = "Y906";
                    break;
                case "都城市":
                    midleAreaCode = "Y771";
                    break;
                case "宮崎市郊外":
                    midleAreaCode = "Y773";
                    break;
                case "日南市":
                    midleAreaCode = "Y777";
                    break;
                case "延岡市・日向市":
                    midleAreaCode = "Y907";
                    break;
                case "宮崎県その他":
                    midleAreaCode = "Y772";
                    break;
                case "鹿児島市　天文館・中央駅・ふ頭":
                    midleAreaCode = "Y780";
                    break;
                case "騎射場・与次郎":
                    midleAreaCode = "Y785";
                    break;
                case "谷山・宇宿":
                    midleAreaCode = "Y786";
                    break;
                case "奄美・屋久島":
                    midleAreaCode = "Y908";
                    break;
                case "霧島市":
                    midleAreaCode = "Y909";
                    break;
                case "鹿児島県その他":
                    midleAreaCode = "Y781";
                    break;
                case "笛吹市":
                    midleAreaCode = "Y796";
                    break;
                case "富士吉田・河口湖":
                    midleAreaCode = "Y936";
                    break;
                case "北杜市":
                    midleAreaCode = "Y937";
                    break;
                case "甲府":
                    midleAreaCode = "Y973";
                    break;
                case "山梨県その他":
                    midleAreaCode = "Y938";
                    break;
                case "安曇野":
                    midleAreaCode = "Y806";
                    break;
                case "諏訪・茅野":
                    midleAreaCode = "Y807";
                    break;
                case "長野市":
                    midleAreaCode = "Y939";
                    break;
                case "松本市":
                    midleAreaCode = "Y940";
                    break;
                case "軽井沢":
                    midleAreaCode = "Y941";
                    break;
                case "上田・佐久":
                    midleAreaCode = "Y942";
                    break;
                case "長野県その他":
                    midleAreaCode = "Y808";
                    break;
                case "岐阜駅周辺・柳ヶ瀬・市役所":
                    midleAreaCode = "Y810";
                    break;
                case "島・則武・正木・長良":
                    midleAreaCode = "Y811";
                    break;
                case "県庁～岐南・柳津・岐阜駅以南":
                    midleAreaCode = "Y812";
                    break;
                case "穂積・北方・大垣":
                    midleAreaCode = "Y813";
                    break;
                case "日野・芥見・各務原":
                    midleAreaCode = "Y814";
                    break;
                case "高山・中津川":
                    midleAreaCode = "Y879";
                    break;
                case "多治見・土岐":
                    midleAreaCode = "Y880";
                    break;
                case "下呂・岐阜県その他":
                    midleAreaCode = "Y988";
                    break;
                case "福井市":
                    midleAreaCode = "Y934";
                    break;
                case "敦賀":
                    midleAreaCode = "Y935";
                    break;
                case "坂井市":
                    midleAreaCode = "Y972";
                    break;
                case "小浜・福井県その他":
                    midleAreaCode = "Y816";
                    break;
                case "新潟駅・万代":
                    midleAreaCode = "Y820";
                    break;
                case "新潟駅南":
                    midleAreaCode = "Y821";
                    break;
                case "古町周辺":
                    midleAreaCode = "Y822";
                    break;
                case "新潟東区・北区エリア":
                    midleAreaCode = "Y823";
                    break;
                case "新潟西エリア":
                    midleAreaCode = "Y824";
                    break;
                case "出来島･女池･桜木･鳥屋野潟周辺":
                    midleAreaCode = "Y825";
                    break;
                case "上越":
                    midleAreaCode = "Y826";
                    break;
                case "新発田":
                    midleAreaCode = "Y827";
                    break;
                case "燕三条":
                    midleAreaCode = "Y881";
                    break;
                case "亀田・新津エリア":
                    midleAreaCode = "Y829";
                    break;
                case "佐渡・新潟県その他":
                    midleAreaCode = "Y828";
                    break;
                case "高岡":
                    midleAreaCode = "Y933";
                    break;
                case "富山市":
                    midleAreaCode = "Y932";
                    break;
                case "黒部・富山県その他":
                    midleAreaCode = "Y831";
                    break;
                case "結城市":
                    midleAreaCode = "Y835";
                    break;
                case "水戸":
                    midleAreaCode = "Y924";
                    break;
                case "つくば":
                    midleAreaCode = "Y925";
                    break;
                case "日立・ひたちなか":
                    midleAreaCode = "Y926";
                    break;
                case "土浦":
                    midleAreaCode = "Y969";
                    break;
                case "笠間・常陸太田・茨城県北部他":
                    midleAreaCode = "Y927";
                    break;
                case "鹿嶋・鉾田・茨城県南部他":
                    midleAreaCode = "Y928";
                    break;
                case "金沢(片町･香林坊･にし茶屋周辺)":
                    midleAreaCode = "Y840";
                    break;
                case "金沢(金沢駅･近江町･ひがし茶屋)":
                    midleAreaCode = "Y841";
                    break;
                case "金沢市他・野々市・白山・内灘":
                    midleAreaCode = "Y842";
                    break;
                case "輪島・七尾・加賀・石川県その他":
                    midleAreaCode = "Y882";
                    break;
                case "桐生市・みどり市":
                    midleAreaCode = "Y843";
                    break;
                case "館林・大泉町・邑楽町":
                    midleAreaCode = "Y844";
                    break;
                case "前橋":
                    midleAreaCode = "Y929";
                    break;
                case "草津・嬬恋":
                    midleAreaCode = "Y930";
                    break;
                case "高崎":
                    midleAreaCode = "Y966";
                    break;
                case "伊勢崎・玉村":
                    midleAreaCode = "Y967";
                    break;
                case "太田市":
                    midleAreaCode = "Y968";
                    break;
                case "伊香保・群馬県その他":
                    midleAreaCode = "Y931";
                    break;
                case "秋田市":
                    midleAreaCode = "Y917";
                    break;
                case "仙北市・秋田県北部":
                    midleAreaCode = "Y918";
                    break;
                case "横手・秋田県南部":
                    midleAreaCode = "Y919";
                    break;
                case "米沢,山形市":
                    midleAreaCode = "Y920";
                    break;
                case "酒田・鶴岡":
                    midleAreaCode = "Y922";
                    break;
                case "山形県その他":
                    midleAreaCode = "Y923";
                    break;
                case "佐賀市":
                    midleAreaCode = "Y959";
                    break;
                case "唐津":
                    midleAreaCode = "Y974";
                    break;
                case "佐賀県その他":
                    midleAreaCode = "Y960";
                    break;
                case "那覇":
                    midleAreaCode = "Y961";
                    break;
                case "糸満・豊見城・南風原・南城":
                    midleAreaCode = "Y962";
                    break;
                case "石垣島・宮古島・沖縄離島":
                    midleAreaCode = "Y963";
                    break;
                case "名護・恩納村・本部町":
                    midleAreaCode = "Y964";
                    break;
                case "読谷･北谷･宜野湾･浦添･嘉手納":
                    midleAreaCode = "Y965";
                    break;
                case "沖縄市・うるま・西原・北中城":
                    midleAreaCode = "Y976";
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

        private void Budget()
        {
            switch (cbBudgetMinMax.SelectedItem)
            {
                case "～501円":
                    budgetCode = "B009";
                    break;
                case "501～1000円":
                    budgetCode = "B010";
                    break;
                case "1001～1500円":
                    budgetCode = "B011";
                    break;
                case "1501～2000円":
                    budgetCode = "B001";
                    break;
                case "2001～3000円":
                    budgetCode = "B002";
                    break;
                case "3001～4000円":
                    budgetCode = "B003";
                    break;
                case "4001～5000円":
                    budgetCode = "B008";
                    break;
                case "5001～7000円":
                    budgetCode = "B004";
                    break;
                case "7001～10000円":
                    budgetCode = "B005";
                    break;
                case "10001～15000円":
                    budgetCode = "B006";
                    break;
                case "15001～20000円":
                    budgetCode = "B012";
                    break;
                case "20001～30000円":
                    budgetCode = "B013";
                    break;
                case "30001円～":
                    budgetCode = "B014";
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            

            lbCover.Background = Brushes.White;
            errorArea.Content = "※地域を選択してください。";


            largeAreaCode = "Z017";
            midleAreaCode = "Y929";



            cbBudgetMinMax.ItemsSource = new string[]
            {
                "指定なし",
                "～501円",
                "501～1000円",
                "1001～1000円",
                "1501～2000円",
                "2001～3000円",
                "3001～4000円",
                "4001～5000円",
                "5001～7000円",
                "7001～10000円",
                "10001～15000円",
                "15001～20000円",
                "20001～30000円",
                "30001円～",
            };

            
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            Budget();
            Genre();
            LargeArea();
            MidleArea();
            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4" +
                            "&large_area=" + largeAreaCode + "&midle_area=" + midleAreaCode + "&genre=" + genreCode + "&budget=" + budgetCode + "&format=json");
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString);
            Conditions(json1);


            if ((string)lbPref.Content == "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content == "")
            {
                errorArea.Content = "※地域を選択してください。";
            }

            if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content != "")
            {
                errorArea.Content = "";
               // imHome.Source = null;
            }

            if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content == "") 
            {
                errorArea.Content = "";
                //imHome.Source = null;
            }

            if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content != "") 
            {
                errorArea.Content = "";
              //  imHome.Source = null;
            }

            if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content == "") 
            {
                errorArea.Content = "";
                //imHome.Source = null;
            }

            #region

            //if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content != "") //1
            //{
            //    lbCover.Background = Brushes.Transparent;
            //    lbSlash.Content = "/";
            //    Genre();
            //    LargeArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&genre=" + genreCode + "&format=json");
            //    //dString = dString.Replace("\"name\":\"ダイニングバー・バル\"", "\"name\":\"ダイニングバーバル\"");
            //    //dString = dString.Replace("\"name\":\"イタリアン・フレンチ\"", "\"name\":\"イタリアンフレンチ\"");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    Conditions(json1);

            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content == "") //2
            //{
            //    lbCover.Background = Brushes.Transparent;
            //    Genre();
            //    LargeArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    Conditions(json1);
            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content != "") //3
            //{
            //    lbCover.Background = Brushes.Transparent;
            //    lbSlash.Content = "/";
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    Conditions(json1);
            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content == "") //4
            //{
            //    lbCover.Background = Brushes.Transparent;
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            //    Conditions(json1);
            //}

            //if ((string)lbPref.Content == "" && (string)lbCity.Content == "" && (string)lbGenre.Content != "") //5
            //{
            //    errorArea.Content = "※地域を選択してください";
            //}

            //if ((string)lbPref.Content == "" && (string)lbCity.Content == "" && (string)lbGenre.Content == "") //6
            //{
            //    errorArea.Content = "※少なくとも一つの条件を入れてください";
            //}

            #endregion

            #region

            //cbBudgetMin.SelectedItem = "指定なし";
            //cbBudgetMax.SelectedItem = "指定なし";
            //cbNumber.SelectedItem = "指定なし";

            //cbBudgetMin.ItemsSource = new string[]
            //{
            //    "指定なし",
            //    "501円",
            //    "1001円",
            //    "1501円",
            //    "2001円",
            //    "3001円",
            //    "4001円",
            //    "5001円",
            //    "7001円",
            //    "10001円",
            //    "15001円",
            //    "20001円",
            //    "30001円",
            //};

            //MenuItem mi = new MenuItem();
            //mi.Header = "500円";
            //mi.IsEnabled = false;
            //cbBudgetMax.Items.Add(mi);

            //cbBudgetMax.ItemsSource = new string[]
            //{
            //    "指定なし",
            //    "500円",
            //    "1000円",
            //    "1500円",
            //    "2000円",
            //    "3000円",
            //    "4000円",
            //    "5000円",
            //    "7000円",
            //    "10000円",
            //    "15000円",
            //    "20000円",
            //    "30000円",
            //};

            //cbNumber.ItemsSource = new string[]
            //{
            //    "指定なし",
            //    "1名",
            //    "2名",
            //    "3名",
            //    "4名",
            //    "5名",
            //    "6名",
            //    "7名",
            //    "8名",
            //    "9名",
            //    "10名",
            //    "20名",
            //    "30名",
            //    "40名",
            //    "50名",
            //    "60名",
            //    "70名",
            //    "80名",
            //    "90名",
            //    "100名",
            //};

            //btSearch.IsEnabled = false;
            #endregion
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            check = 1;
            var area = new Area();
            NavigationService.Navigate(area);

            
        }

        private void goGenre_Click_1(object sender, RoutedEventArgs e) {
            var genre = new Genre();
            NavigationService.Navigate(genre);
        }


        private void Conditions(Rootobject json1)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            var list1 = new List<TextBlock>();
            var tb1 = new TextBlock[] { tbShopName1, tbShopName2, tbShopName3, tbShopName4, tbShopName5, tbShopName6, tbShopName7, tbShopName8, tbShopName9, tbShopName10 };
            list1.AddRange(tb1);
            var list2 = new List<TextBlock>();
            var tb2 = new TextBlock[] { tbAddress1, tbAddress2, tbAddress3, tbAddress4, tbAddress5, tbAddress6, tbAddress7, tbAddress8, tbAddress9, tbAddress10 };
            list2.AddRange(tb2);
            var list3 = new List<TextBlock>();
            var tb3 = new TextBlock[] { tbOpen1, tbOpen2, tbOpen3, tbOpen4, tbOpen5, tbOpen6, tbOpen7, tbOpen8, tbOpen9, tbOpen10 };
            list3.AddRange(tb3);
            var list4 = new List<Label>();
            var lb = new Label[] { lbBudget1, lbBudget2, lbBudget3, lbBudget4, lbBudget5, lbBudget6, lbBudget7, lbBudget8, lbBudget9, lbBudget10 };
            list4.AddRange(lb);
            var list5 = new List<TextBlock>();
            var tb5 = new TextBlock[] { tbCatchPhrase1, tbCatchPhrase2, tbCatchPhrase3, tbCatchPhrase4, tbCatchPhrase5, tbCatchPhrase6, tbCatchPhrase7, tbCatchPhrase8, tbCatchPhrase9, tbCatchPhrase10 };
            list5.AddRange(tb5);

            var list6 = new List<Label>();
            var lb6 = new Label[] { lbAddress1, lbAddress2, lbAddress3, lbAddress4, lbAddress5, lbAddress6, lbAddress7, lbAddress8, lbAddress9, lbAddress10 };
            list6.AddRange(lb6);
            var list7 = new List<Label>();
            var lb7 = new Label[] { lbOpen1, lbOpen2, lbOpen3, lbOpen4, lbOpen5, lbOpen6, lbOpen7, lbOpen8, lbOpen9, lbOpen10 };
            list7.AddRange(lb7);
            var list8 = new List<Label>();
            var lb8 = new Label[] { lb1Budget1, lb1Budget2, lb1Budget3, lb1Budget4, lb1Budget5, lb1Budget6, lb1Budget7, lb1Budget8, lb1Budget9, lb1Budget10 };
            list8.AddRange(lb8);


            Image[] image1 = { im11, im21, im31, im41, im51, im61, im71, im81, im91, im101, };
            Image[] image2 = { im12, im22, im32, im42, im52, im62, im72, im82, im92, im102, };

            //int count = int.Parse(json1.results.results_returned);
            int zero = json1.results.results_start;
            if (zero == 1 && check == 1)
            {
                tb1 = null;
                tb2 = null;
                tb3 = null;
                lb = null;
                tb5 = null;
                //MessageBox.Show("ありません");


                //string path1 = "HotpepperGourmetSystem.Images.error.jpg";

                //BitmapImage bmpImg = new BitmapImage();
                //bmpImg.BeginInit();

                //Assembly assembly = Assembly.GetExecutingAssembly();
                //Stream stream = assembly.GetManifestResourceStream(path1);
                //bmpImg.StreamSource = stream;
                //bmpImg.EndInit();

                //imError.Source = bmpImg;
            }

            //if (zero >= 0)
            //{
            //    imError.Source = null;
            //}

            for (int i = 0; i < int.Parse(json1.results.results_returned); i++)
            {
                tb1[i].Text = json1.results.shop[i].name;
                tb2[i].Text = json1.results.shop[i].address;
                tb3[i].Text = json1.results.shop[i].open;
                lb[i].Content = json1.results.shop[i].access;
                tb5[i].Text = json1.results.shop[i].other_memo;

                var imageUrl1 = json1.results.shop[i].photo.pc.l;
                BitmapImage imagesorse1 = new BitmapImage(new Uri(imageUrl1));
                image1[i].Source = imagesorse1;
                var imageUrl2 = json1.results.shop[i].logo_image;
                BitmapImage imagesorse2 = new BitmapImage(new Uri(imageUrl2));
                image2[i].Source = imagesorse2;

                lb6[i].Content = "所在地";
                lb7[i].Content = "営業時間";
                lb8[i].Content = "アクセス";
            }

        }

        private void btUrl1_Click(object sender, RoutedEventArgs e)
        {
            //var wc = new WebClient()
            //{
            //    Encoding = Encoding.UTF8
            //};


            //    if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content != "")
            //{
            //    Genre();
            //    LargeArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&genre=" + genreCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //    btUrl(json1);
            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content == "指定なし" && (string)lbGenre.Content == "") //2
            //{
            //    Genre();
            //    LargeArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&large_area=" + largeAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //    btUrl(json1);

            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content != "") //3
            //{
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //    btUrl(json1);

            //}

            //if ((string)lbPref.Content != "" && (string)lbCity.Content != "指定なし" && (string)lbGenre.Content == "") //4
            //{
            //    Genre();
            //    LargeArea();
            //    MidleArea();
            //    var dString1 = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&middle_area=" + midleAreaCode + "&format=json");
            //    var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //    btUrl(json1);

            //}
        }

        private void btUrl(Rootobject json1)
        {
            //var list1 = new List<Button>();
            //var bt1 = new Button[] { btUrl1, btUrl2, btUrl3, btUrl4, btUrl5, btUrl6, btUrl7, btUrl8, btUrl9, btUrl10 };
            //list1.AddRange(bt1);

            //for (int i = 0; i < 10; i++)
            //{
            //    bt1[i].Content = json1.results.shop[i].urls.pc;
            //    System.Diagnostics.Process.Start((string)bt1[i].Content);
            //}
        }

        private void cbBudgetMinMax_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            Budget();
            MidleArea();
            Genre();
            LargeArea();
            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4" +
                            "&large_area=" + largeAreaCode + "&midle_area=" + midleAreaCode + "&genre=" + genreCode + "&budget=" + budgetCode + "&format=json");
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString);
            Conditions(json1);
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            parent.Close();
        }
    }
}
