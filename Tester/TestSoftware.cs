using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 15:02:24
*/
namespace Tester
{
    public class TestSoftware : ITester
    {
        private SoftwareCreator creator = new SoftwareCreator();
        private SampleDataFactory factory = new SampleDataFactory();
        public void Test()
        {
            List<string> results = factory.GetSampleData(creator, 15);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
