using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 14:58:55
*/
namespace SampleData
{
    public class SoftwareCreator : ISampleDataCreator
    {
        public SoftwareCreator()
        {
            r = new Random();
            software = SampleDataFileRead.ReadFromFile("Software.txt");
        }
        public string Create()
        {
            return software[r.Next(0, software.Length - 1)]+r.Next(1000,9999).ToString();
        }

        private Random r;
        private string[] software;
    }
}
