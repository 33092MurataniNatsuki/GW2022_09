﻿using Newtonsoft.Json;
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

            var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=0e8af5f2f79eb4f4&id=" + id + "&format=json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

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
            
        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
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
        }
    }
}
