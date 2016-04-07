﻿using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/7 14:41:24
*/
namespace Tester
{
    public class TestSampleDataPersonName : ITester
    {
        private ISampleDataCreator creator = new PersonNameCreator();
        private SampleDataFactory factory = new SampleDataFactory();
        public void Test()
        {
            List<string> personNames = factory.GetSampleData(creator, 10);
            foreach (var item in personNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}