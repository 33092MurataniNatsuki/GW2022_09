using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotpepperGourmetSystem
{
    public class MidleAreaCodeCounter
    {
        private IEnumerable<MidleArea> _mdCode;  //csvファイルから読み込んだデータ

        //コンストラクタ
        public MidleAreaCodeCounter(string filePath)
        {
            _mdCode = ReadAreas(filePath);
        }

        //public static IDictionary<string, string> ReadAreas(string filePath)
        //{
        //    var dict = new Dictionary<string, string>();
        //    string[] lines = File.ReadAllLines(filePath);

        //    foreach (string line in lines)
        //    {
        //        string[] items = line.Split(',');
        //        dict.Add(items[0], items[1]);
        //    }
        //    return dict;
        //}

        public static IEnumerable<MidleArea> ReadAreas(string filePath)
        {
            List<MidleArea> areas = new List<MidleArea>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                MidleArea midlearea = new MidleArea
                {
                    MidleAreaName = items[0],
                    MidleAreaCode = items[1]
                };
                areas.Add(midlearea);
            }
            return areas;
        }
    }
}
