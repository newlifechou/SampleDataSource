using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    /// <summary>
    /// 读取文本数据文件
    /// </summary>
    public class IOOperation
    {

        public IOOperation()
        {

        }
        /// <summary>
        /// 读取文本文件的所有行到一个string[]
        /// </summary>
        /// <param name="dataFileName"></param>
        /// <returns></returns>
        public string[] ReadFromDataFile(string dataFileName)
        {
            try
            {
                string dataFilePath = Path.Combine("Data", dataFileName);
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
