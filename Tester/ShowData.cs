using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 15:06:03
*/
namespace Tester
{
    public static class ShowData
    {
        public static void Show(List<string> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
