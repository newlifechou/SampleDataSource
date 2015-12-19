using SampleDataSource.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataSource
{
    public class StoreData
    {
        /// <summary>
        /// 获取随即的单个产品对象
        /// </summary>
        /// <returns></returns>
        public static Product GetSingleProduct()
        {
            Product p = new Product() {
                Id=RN.GetNo99(),
                ProductName =RN.GetNameNo9999(),
                Price =RN.GetNo999(),
                ProducerId =1,
                ProductionDate =new DateTime(2015,12,12),
                Quantity =RN.GetNo999()
            };
            return p;
        }
        /// <summary>
        /// 获取随即的产品列表
        /// </summary>
        /// <param name="dataCount"></param>
        /// <returns></returns>
        public static List<Product> GetProudcts(int dataCount)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < dataCount; i++)
            {
                Product p = new Product() { };
                p.Id = RN.GetNo9999();
                p.Price = RN.GetNo999();
                p.ProductName = RN.GetNameNo9999();
                p.ProductionDate = new DateTime(RN.GetNo(2010, 2015), RN.GetNo(1,12), RN.GetNo(1,28));
                p.ProducerId = RN.GetNo9();
                p.CategoryId = RN.GetNo9();
                products.Add(p);
            }
            return products;
        }
    }
}
