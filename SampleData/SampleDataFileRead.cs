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
    public static class SampleDataFileRead
    {
        public static string[]  ReadFromFile(string dataFileName)
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
    }
}
