using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    /// <summary>
    /// 一个简化调用的随机数类
    /// </summary>
    public class RN
    {
        private Random r;
        public RN()
        {
            r = new Random();
        }
        /// <summary>
        /// 返回介于两个值之间的整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomInt(int min,int max)
        {
            return r.Next(min, max);
        }
    }
}
