using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleData
{
    /// <summary>
    /// 样板数据工厂
    /// </summary>
    public class SampleDataFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="creator">创建器</param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<string> GetSampleData(ISampleDataCreator creator,int count)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < count; i++)
            {
                results.Add(creator.Create());
            }
            return results;
        }
    }
}
