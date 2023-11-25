using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosishnevaAN.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = (Convert.ToDouble(strX) * Convert.ToDouble(strX) * Convert.ToDouble(strX) - 4.0 * Convert.ToDouble(strX)) / Math.Cos(Convert.ToDouble(strX));
            res = Math.Round(res, 3);
            return res;
             

        }
    }
}
