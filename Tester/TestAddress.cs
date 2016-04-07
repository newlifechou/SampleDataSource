using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class TestAddress : ITester
    {
        private AddressCreator creator = new AddressCreator();
        private SampleDataFactory factory = new SampleDataFactory();
        public void Test()
        {
            ShowData.Show(factory.GetSampleData(creator, 50));
        }
    }
}
