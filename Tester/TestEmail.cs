using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 21:41:31
*/
namespace Tester
{
    public class TestEmail : ITester
    {
        private EmailCreator creator = new EmailCreator();
        private SampleDataFactory factory = new SampleDataFactory();

        public void Test()
        {
            ShowData.Show(factory.GetSampleData(creator,50));
        }
    }
}
