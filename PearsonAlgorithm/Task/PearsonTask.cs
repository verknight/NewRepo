using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class PearsonTask
    {   
        public static Double GetMaxValue(Double[] input)
        {
            Double maxDoomy = input[0];
            int length = input.Length , i;
            for (i = 1; i < length; i++)
            {
                if (input[i] > maxDoomy)
                {
                    maxDoomy = input[i];
                }
            }
            return maxDoomy;
        }
        public static Double GetEverageValue(Double[] input)
        {
            Double everageDoomy = 0;
            int length = input.Length , i;
            for (i = 0; i < length; i++)
            {
                everageDoomy = ((everageDoomy += input[i]) / length);
            }
            return everageDoomy;
        }
        public static Double[] Clone(Double[] input)
        {
            Double[] outDoomy = new Double[input.Length];
            int length = input.Length, i;
            for (i = 0; i < length; i++)
            {
                outDoomy[i] = input[i];
            }
            return outDoomy;
        }
        public static void Reserve(ref Double[] input)
        {
            int length = input.Length , i;
            double tmp;
            for (i = 0; i < length; i++)
            {
                tmp = input[i];
                input[i] = input[length - 1 -i];
                input[length - 1 - i] = tmp;
            }
        }
        public static int IdentifyMatrix(Double[,] matrix)
        {
            int _1stDL = matrix.GetLength(0);
            int _2ndDL = matrix.GetLength(1);
            if (_1stDL == 1 || _2ndDL == 1)//Single row matrix
            {
                return _1stDL == 1 ? 1 : 2;
            }
            return -1;
        }
        public static Double[,] multiplyMatrix(Double[,] matrixX, Double[,] matrixY)
        {   
            int X_1stDL = matrixX.GetLength(0);
            int X_2ndDL = matrixX.GetLength(1);
            int Y_1stDL = matrixY.GetLength(0);
            int Y_2ndDL = matrixY.GetLength(1);
            int i, j, k;
            Double[,] matrixZ;
            //[1] x [1]
            if (((X_1stDL == Y_1stDL) && (X_2ndDL == Y_2ndDL)) && (X_1stDL == Y_1stDL) && (X_1stDL == 1))
            {
                
            }
            if (((X_1stDL == X_2ndDL) && (Y_1stDL == Y_2ndDL)) && (X_1stDL == Y_1stDL))
            {
                //Square matrix - assign xLength
                int length = X_1stDL;
                matrixZ = new Double[length, length];
                for (i = 0; i < length; i++)
                {
                    for (j = 0; j < length; j++)
                    {
                        for (k = 0; k < length; k++)
                        {
                            matrixZ[i, j] = matrixX[i, k] * matrixY[k, j];
                        }
                    }
                }
                return matrixZ;
            }
            return null;
        }
    }
}
