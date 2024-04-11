using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ExpertsCalculator
{
    internal class Matching
    {
        static void Main(string[] args)
        {
            double[,] matrix = {
            {1, 3, 1, 1},
            {2, 2, 3, 3},
            {5, 4, 4, 5},
            {4, 5, 5, 5},
            {3, 1, 2, 2 }
        };

            double[,] spearmanMatrix = CalculateSpearman(matrix);

            Console.WriteLine("Spearman's correlation matrix:");
            for (int i = 0; i < spearmanMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < spearmanMatrix.GetLength(1); j++)
                {
                    Console.Write(spearmanMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static double[,] CalculateSpearman(double[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            double[,] spearmanMatrix = new double[columnCount, columnCount];

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    double[] column1 = GetColumn(matrix, i);
                    double[] column2 = GetColumn(matrix, j);
                    double spearman = CalculateSpearmanCoefficient(column1, column2);
                    spearmanMatrix[i, j] = spearman;
                }
            }

            return spearmanMatrix;
        }

        static double[] GetColumn(double[,] matrix, int columnIndex)
        {
            int rowCount = matrix.GetLength(0);
            double[] column = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                column[i] = matrix[i, columnIndex];
            }
            return column;
        }

        static double CalculateSpearmanCoefficient(double[] x, double[] y)
        {
            double sumSquaredDifferences = 0;
            int n = x.Length;

            // Rank the values
            double[] rankX = new double[n];
            double[] rankY = new double[n];

            Array.Copy(x, rankX, n);
            Array.Copy(y, rankY, n);

            Array.Sort(rankX);
            Array.Sort(rankY);

            for (int i = 0; i < n; i++)
            {
                int indexX = Array.IndexOf(rankX, x[i]) + 1;
                int indexY = Array.IndexOf(rankY, y[i]) + 1;

                double d = indexX - indexY;
                sumSquaredDifferences += d * d;
            }

            double spearmanCoefficient = 1 - (6 * sumSquaredDifferences) / (n * (n * n - 1));

            return spearmanCoefficient;
        }
    }
}
