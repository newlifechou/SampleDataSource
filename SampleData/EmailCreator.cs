using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 21:38:48
*/
namespace SampleData
{
    public class EmailCreator : ISampleDataCreator
    {
        public EmailCreator()
        {
            firstName = Common.ReadFromFile("FirstName.txt");
            emails = Common.ReadFromFile("Email.txt");
        }
        public string Create()
        {
            return Common.RandOne(firstName) + "@" + Common.RandOne(emails);
        }

        private string[] firstName;
        private string[] emails;
    }
}
