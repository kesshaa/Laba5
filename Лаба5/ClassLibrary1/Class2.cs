using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Variant_0
    {


        //задание 1
        public static double[,] Task1(double[,] P)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (P[i, j] == 0)
                    {
                        P[i, j] = 500;
                    }
                }
            }
            return P;
        }

        //задание 2 
        public static double[,] Task2(double[,] P)
        {
            int otr = 0;
            for (int i = 0; i < 4; i++)
            {
                if (P[i, 4] < 0)
                { otr++; }
            }
            return P;
        }

        //задание 3
        public static double[] Task3(double[,] P)
        {

           
                double[] T = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    int PosCount = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (P[i, j] > 0)
                        {
                            PosCount++;
                        }
                    }
                    T[i] = PosCount;
                }
                return T;
            
        }
        //4
        public static double[] Task4(double[,] P)
        {
            double[] D = new double[10];
            int ind = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (P[i, j] < 0)
                    {
                        D[ind] = P[i, j];
                        ind++;
                    }
                    if (ind == 10)
                    {
                        return D;
                    }
                }
            }
            return D.Take(ind).ToArray();
        }
    }
}
    
