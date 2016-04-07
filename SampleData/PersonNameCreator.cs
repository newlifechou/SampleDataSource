using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 14:21:52
*/
namespace SampleData
{
    public class PersonNameCreator : ISampleDataCreator
    {
        public PersonNameCreator()
        {
            firstName = Common.ReadFromFile("FirstName.txt");
            lastName = Common.ReadFromFile("LastName.txt");
        }
        public string Create()
        {
            string result = string.Empty;
            if (firstName.Length > 0 && lastName.Length > 0)
            {
                result = Common.RandOne(firstName) + " " + Common.RandOne(lastName);
            }
            return result;
        }
        private string[] firstName;
        private string[] lastName;

    }
}
