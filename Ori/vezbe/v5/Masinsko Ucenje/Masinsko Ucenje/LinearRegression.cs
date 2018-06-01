using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masinsko_Ucenje
{
    public class LinearRegression
    {
        public double k { get; set; }
        public double n { get; set; }

	    public void fit(double[] x, double[] y) {
            // TODO 2: implementirati fit funkciju koja odredjuje parametre k i n
            // y = kx + n

           
            double upNum1 = 0;
            double upNum2 = 0;
            double upNum3 = 0;
            double downNum1 = 0;
        

            for (int i = 0; i < x.Length; i++)
            {
                upNum1 += x[i] * y[i];
                upNum2 += x[i];
                upNum3 += y[i];
                downNum1 += Math.Pow(x[i], 2);
            }

            k = (x.Length * upNum1 - upNum1 * upNum2) / (x.Length * downNum1 - upNum2);
            n = (1/x.Length)*(upNum3 - k*upNum2);        

        }

        public double predict(double x)
        {   
            // TODO 3: Implementirati funkciju predict koja na osnovu x vrednosti vraca
            // predvinjenu vrednost y

            return k*x + n;
        }
    }
}
