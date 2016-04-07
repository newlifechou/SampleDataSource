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
            r = new Random();
            firstName = SampleDataFileRead.ReadFromFile("FirstName.txt");
            lastName = SampleDataFileRead.ReadFromFile("LastName.txt");
        }
        public string Create()
        {
            string result = string.Empty;
            if (firstName.Length > 0 && lastName.Length > 0)
            {
                result = firstName[r.Next(0, firstName.Length - 1)] + " " + lastName[r.Next(0, lastName.Length - 1)];
            }
            return result;
        }
        private Random r;
        private string[] firstName;
        private string[] lastName;

    }
}
