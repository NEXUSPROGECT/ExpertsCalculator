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
        public static void MainCalculate(double[,] matrix, DataGridView dataGridView, double tHold, PictureBox picturebox)
        {

            int[,] diGraf = new int[matrix.GetLength(1), matrix.GetLength(1)];


            // Очищаем DataGridView перед добавлением новых данных
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Добавляем столбцы в DataGridView
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                dataGridView.Columns.Add($"Column{j}", $"Column{j + 1}");
            }

            // Добавляем строки и устанавливаем значения из матрицы
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                // Добавляем строку в DataGridView
                dataGridView.Rows.Add();
            }






            

            double[,] spearmanMatrix = CalculateSpearman(matrix);

            for (int i = 0; i < spearmanMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < spearmanMatrix.GetLength(1); j++)
                {
                    if (spearmanMatrix[i, j] >= tHold)
                    {
                        diGraf[i, j] = 1;
                        dataGridView.Rows[i].Cells[j].Value = 1;
                    }
                    else 
                    { 

                        diGraf[i, j] = 0;
                        dataGridView.Rows[i].Cells[j].Value = 0;
                    }
                }
            }


            DisplayGraph.DrawDirectedGraph(diGraf, picturebox);
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
