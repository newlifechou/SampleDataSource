using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleData
{
    public class AddressCreator : ISampleDataCreator
    {
        public AddressCreator()
        {
            cities = Common.ReadFromFile("City.txt");
            provinces = Common.ReadFromFile("Province.txt");
        }
        public string Create()
        {
            return Common.RandOne(provinces) + " " + Common.RandOne(cities);
        }

        private string[] cities;
        private string[] provinces;
    }
}
