using System;

namespace ProcessorHeatmap
{
    public static class Utils
    {
        public static (int, int) CalculateDimensions(int cellsCount)
        {
            // work out how many columns and rows we need (closest square values)
            double idealWidthAndHeight = Math.Sqrt(cellsCount);
            int cols = (int)Math.Truncate(idealWidthAndHeight);
            if (cols < idealWidthAndHeight)
            {
                cols++;
            }
            int rows = (int)Math.Truncate(idealWidthAndHeight);
            return (cols, rows);
        }
    }
}