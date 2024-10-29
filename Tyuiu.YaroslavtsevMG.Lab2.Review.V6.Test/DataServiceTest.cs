using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YaroslavtsevMG.Lab2.Review.V6.Lib;

namespace Tyuiu.YaroslavtsevMG.Lab2.Review.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMassFunction()
        {
            double[] array = { -2.82,
-13.66,
4.38,
1.17,
0.17,
0.09,
1.82,
-15.48,
-3.16,
-1.44
};
            var lib = new DataService();
            CollectionAssert.AreEqual(array,lib.GetMassFunction(0,10));
        }
    }
}
