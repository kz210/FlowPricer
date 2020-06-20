using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Excel;

namespace FlowPricer.Utilities
{
    public static class ExcelHelper
    {
        public static T[] ToNet1DimArray<T>(this Range range, Func<object, T> typeConverter)
        {
            object[,] oArray = range.Value2;
            int firstDim = oArray.GetLength(0);
            int secondDim = oArray.GetLength(1);
            if (firstDim != 1 && secondDim != 1)
            {
                throw new ArgumentOutOfRangeException("range", "Expected 1 dimensional range, which is not detected!");
            }
            bool isHorizontal = firstDim == 1;
            int dim = isHorizontal ? secondDim : firstDim;
            T[] tArray = new T[dim];
            try
            {
                for (int i = 1; i <= dim; i++)
                {
                    int x = isHorizontal ? 1 : i;
                    int y = isHorizontal ? i : 1;
                    tArray[i - 1] = typeConverter(oArray[x, y]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("None-doulble elelments in the 1D array. " + e);
            }

            return tArray;              
        } // method

        public static T[,] ToNet2DimArray<T>(this Range range, Func<object, T> typeConverter)
        {
            object[,] oArray = range.Value2;
            int firstDim = oArray.GetLength(0);
            int secondDim = oArray.GetLength(1);
            T[,] tArray = new T[firstDim, secondDim];
            try
            {
                for (int i = 1; i <= firstDim; i++)
                {
                    for (int j = 1; j <= secondDim; j++)
                    {
                        tArray[i - 1, j - 1] = typeConverter(oArray[i, j]);
                    }
                }

            }
            catch (InvalidCastException e)
            {
                throw new Exception("None-doulble elelments in the 2D array. " + e);
            }


            return tArray;       
        }

    }//class
}//namespace
