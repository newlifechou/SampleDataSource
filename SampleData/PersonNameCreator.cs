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
        public string Create()
        {
            Random r = new Random();
            string result = string.Empty;
            if (FirstName.Count > 0 && LastName.Count > 0)
            {
                result = FirstName[r.Next(0, FirstName.Count - 1)] + " " + LastName[r.Next(0, LastName.Count - 1)];
            }
            return result;
        }

        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

    }
}
