using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataSource
{
    /// <summary>
    /// 这个类是按照需求来产生随机名称的
    /// 静态工具类
    /// </summary>
    static class RN
    {
        private static Random r;
        static RN()
        {
            //生成随机数种子
            r = new Random();
        }

        public static int GetNo(int min, int max)
        {
            return r.Next(min, max);
        }

        public static int GetNo9()
        {
            return GetNo(0, 9);
        }

        public static int GetNo99()
        {
            return GetNo(10, 99);
        }

        public static int GetNo999()
        {
            return GetNo(100, 999);
        }

        public static int GetNo9999()
        {
            return GetNo(1000, 9999);
        }

        public static string GetNameNo(Func<int> getNumber)
        {
            string[] readyName = { "Apple", "Banana", "Pear", "Pumpkin", "Orange" };
            string firstPart = readyName[r.Next(0, readyName.Count())];
            if (getNumber != null)
            {
                return firstPart + getNumber().ToString();
            }
            return firstPart;
        }
        public static string GetNameNo9999()
        {
            return GetNameNo(GetNo9999);
        }
    }
}
