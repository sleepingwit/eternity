using System;
using Eternity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TabFileGrinderTest
{
    internal class MyData
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TabFileGrinder grinder = new TabFileGrinder();
            grinder.Initialize(String.Empty);
            MyData data = grinder.GetSuprise<MyData>(String.Empty, 1, Suprise);
            
        }

        private MyData Suprise(TabFileLine line)
        {
            MyData data = new MyData();
            data.p1 = line.GetInt32("Nimei");
            data.p2 = line.GetInt32("woqu");
        }
    }
}
