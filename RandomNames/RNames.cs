using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    /// <summary>
    /// 产生随机名称
    /// </summary>
    public class RNames
    {
        private IOOperation ioop;
        private RN rn;
        private string[] companyName;
        private string[] firstName;
        private string[] lastName;
        private string[] software;
        private string[] softwareCategory;
        private string[] softwareEdtion;


        public RNames()
        {
            ioop = new IOOperation();
            rn = new RN();
            InitialDataStringArray();
        }
        /// <summary>
        /// 初始化数组
        /// </summary>
        private void InitialDataStringArray()
        {
            companyName = ioop.ReadFromDataFile("Company.txt");
            firstName = ioop.ReadFromDataFile("FirstName.txt");
            lastName = ioop.ReadFromDataFile("LastName.txt");
            software = ioop.ReadFromDataFile("Software.txt");
            softwareCategory = ioop.ReadFromDataFile("SoftwareCategory.txt");
            softwareEdtion = ioop.ReadFromDataFile("SoftwareEdition.txt");
        }
        /// <summary>
        /// 随机返回一个整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetRandomInt(int min,int max)
        {
            return rn.RandomInt(min, max);
        }
        /// <summary>
        /// 随即返回名称数组的某一个值
        /// </summary>
        /// <param name="dataArray"></param>
        /// <returns></returns>
        private string GetRandStr(string[] dataArray)
        {
            if (dataArray.Count() == 0)
            {
                throw new Exception("the data array is empty");
            }
            if (dataArray.Count() == 2)
            {
                return dataArray[dataArray.Count() - 1];
            }
            return dataArray[rn.RandomInt(1, dataArray.Count() - 1)];
        }
        /// <summary>
        /// 得到随机公司名称
        /// </summary>
        /// <returns></returns>
        public string GetOneCompany()
        {
            return GetRandStr(companyName);
        }
        /// <summary>
        /// 获取随机姓名
        /// </summary>
        /// <returns></returns>
        public string GetOnePersonName()
        {
            return GetRandStr(firstName) +" "+ GetRandStr(lastName);
        }

        /// <summary>
        /// 获取随机软件名称
        /// </summary>
        /// <returns></returns>
        public string GetOneSoftwareName()
        {
            return GetRandStr(software) + " " + GetRandStr(softwareEdtion) +" "+ rn.RandomInt(1995, 2016).ToString();
        }
        /// <summary>
        /// 获取随机软件类别
        /// </summary>
        /// <returns></returns>
        public string GetOneSoftwareCategory()
        {
            return GetRandStr(softwareCategory);
        }

    }
}
