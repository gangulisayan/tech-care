using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public void  Verfiy_UnitTest1()
        {
            var names = new List<String>();
            names.Add("java");
            names.Add("testing");
            names.Add("C#");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }

      
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1 ut = new UnitTest1();
            ut.Verfiy_UnitTest1();
        }
    }
}
