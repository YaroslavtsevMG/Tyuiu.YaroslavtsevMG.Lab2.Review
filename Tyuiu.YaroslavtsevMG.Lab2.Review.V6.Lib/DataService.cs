using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.YaroslavtsevMG.Lab2.Review.V6.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            var res = new double[10];
            double x=startValue;
            for(int i=0;i<10;i++)
            {
                x =+ i * (double)(stopValue - startValue) / 10;
                res[i] = Math.Round((1.0 + Math.Sin(Math.Sqrt(x * x + 1.0))) / (Math.Cos((12.0 * x - 4.0))),2);
            }
            return res;
        }
    }
}
