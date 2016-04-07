using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 14:44:42
*/
namespace SampleData
{
    public static class Common
    {
   
        private static  Random r;
        static Common()
        {
            r = new Random();
        }
        /// <summary>
        /// 返回传入字符串数据当中随机的一个
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string RandOne(string[] data)
        {
            return data[r.Next(0, data.Length - 1)];
        }
        /// <summary>
        /// 按行读取数据文件到字符串数据
        /// </summary>
        /// <param name="dataFileName"></param>
        /// <returns></returns>
        public static string[] ReadFromFile(string dataFileName)
        {
            try
            {
                string dataFilePath = Path.Combine("SampleDataFile", dataFileName);
                string[] results = File.ReadAllLines(dataFilePath);
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int RandInt(int min,int max)
        {
            return r.Next(min, max);
        }
    }
}
