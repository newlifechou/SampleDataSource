using SampleDataSource.Store;
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
            for (int i = 0; i < 10; i++)
            {
                var p = StoreData.GetSingleProduct();
                Console.Write(p.ProductName);
                Console.Write(" ");
                Console.WriteLine(p.Price);
            }

            Console.Read();
        }
    }
}
