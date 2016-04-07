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
            software = Common.ReadFromFile("Software.txt");
            softwareEdition = Common.ReadFromFile("SoftwareEdition.txt");
        }
        public string Create()
        {
            return Common.RandOne(software) + " " +Common.RandInt(1000,9999).ToString() + " " + Common.RandOne(softwareEdition);
        }

        private string[] software;
        private string[] softwareEdition;
    }
}
