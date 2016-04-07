using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 20:29:01
*/
namespace SampleData
{
    public class CompanyCreator : ISampleDataCreator
    {
        public CompanyCreator()
        {
            Companies = SampleDataFileRead.ReadFromFile("Company.txt");
            r = new Random();
        }
        public string Create()
        {
            return Companies[r.Next(0, Companies.Length - 1)];
        }
        private Random r;
        private string[] Companies;
    }
}
