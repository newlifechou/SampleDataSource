using RandomNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            RNames r = new RNames();
            for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine(r.GetOneCompany());
                //Console.WriteLine(r.GetOnePersonName());
                //Console.WriteLine(r.GetOneSoftwareCategory());
                Console.WriteLine(r.GetOneSoftwareName());
            }

            Console.Read();
        }
    }
}
