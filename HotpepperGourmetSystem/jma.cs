﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotpepperGourmetSystem
{


    public class Rootobject
    {
        public Results results { get; set; }
    }

    public class Results
    {
        public string api_version { get; set; }
        public int results_available { get; set; }
        public string results_returned { get; set; }
        public int results_start { get; set; }
        public Shop[] shop { get; set; }
    }

    public class Shop
    {
        public string access { get; set; }
        public string address { get; set; }
        public string band { get; set; }
        public string barrier_free { get; set; }
        public Budget budget { get; set; }
        public string budget_memo { get; set; }
        public int capacity { get; set; }
        public string card { get; set; }
        public string _catch { get; set; }
        public string charter { get; set; }
        public string child { get; set; }
        public string close { get; set; }
        public Coupon_Urls coupon_urls { get; set; }
        public string course { get; set; }
        public string english { get; set; }
        public string free_drink { get; set; }
        public string free_food { get; set; }
        public Genre2 genre { get; set; }
        public string horigotatsu { get; set; }
        public string id { get; set; }
        public string karaoke { get; set; }
        public int ktai_coupon { get; set; }
        public Large_Area large_area { get; set; }
        public Large_Service_Area large_service_area { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string logo_image { get; set; }
        public string lunch { get; set; }
        public Middle_Area middle_area { get; set; }
        public string midnight { get; set; }
        public string mobile_access { get; set; }
        public string name { get; set; }
        public string name_kana { get; set; }
        public string non_smoking { get; set; }
        public string open { get; set; }
        public string other_memo { get; set; }
        public string parking { get; set; }
        public object party_capacity { get; set; }
        public string pet { get; set; }
        public Photo photo { get; set; }
        public string private_room { get; set; }
        public Service_Area service_area { get; set; }
        public string shop_detail_memo { get; set; }
        public string show { get; set; }
        public Small_Area small_area { get; set; }
        public string station_name { get; set; }
        public Sub_Genre sub_genre { get; set; }
        public string tatami { get; set; }
        public string tv { get; set; }
        public Urls urls { get; set; }
        public string wedding { get; set; }
        public string wifi { get; set; }
    }

    public class Budget
    {
        public string average { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Coupon_Urls
    {
        public string pc { get; set; }
        public string sp { get; set; }
    }

    public class Genre2
    {
        public string _catch { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Large_Area
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Large_Service_Area
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Middle_Area
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Photo
    {
        public Mobile mobile { get; set; }
        public Pc pc { get; set; }
    }

    public class Mobile
    {
        public string l { get; set; }
        public string s { get; set; }
    }

    public class Pc
    {
        public string l { get; set; }
        public string m { get; set; }
        public string s { get; set; }
    }

    public class Service_Area
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Small_Area
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Sub_Genre
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Urls
    {
        public string pc { get; set; }
    }


}
