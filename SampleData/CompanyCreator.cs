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
            companies = Common.ReadFromFile("Company.txt");
        }
        public string Create()
        {
            return Common.RandOne(companies);
        }
        private string[] companies;
    }
}
