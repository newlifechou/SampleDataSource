using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 14:41:24
*/
namespace Tester
{
    public class TestPersonName : ITester
    {
        private ISampleDataCreator creator = new PersonNameCreator();
        private SampleDataFactory factory = new SampleDataFactory();
        public void Test()
        {
            ShowData.Show(factory.GetSampleData(creator, 10));
        }
    }
}
