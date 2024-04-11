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
        public static void CalculateAndDisplay(DataGridView dataGridView, double[,] opinionMatrix, double threshold, ZedGraphControl zedGraph)
        {
            int rowCount = opinionMatrix.GetLength(0);
            int colCount = opinionMatrix.GetLength(1);

            // Очищаем DataGridView от предыдущих данных
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Добавляем столбцы в DataGridView
            for (int j = 0; j < colCount; j++)
            {
                dataGridView.Columns.Add("Column" + j, "Column" + j);
            }

            // Добавляем строки в DataGridView и заполняем их данными из opinionMatrix
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < colCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = opinionMatrix[i, j];
                }
            }

            // Вычисляем и выводим матрицу согласования
            double[] rowSums = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < colCount; j++)
                {
                    rowSum += opinionMatrix[i, j];
                }
                rowSums[i] = rowSum;
            }

            double totalSum = 0;
            for (int i = 0; i < rowCount; i++)
            {
                totalSum += rowSums[i];
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = rowSums[i] / totalSum;
                }
            }

            int[,] mat = new int[rowCount,colCount];
            // Сравниваем значения с пороговым значением
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    double value = (double)dataGridView.Rows[i].Cells[j].Value;
                    if (value >= threshold)
                    {
                        mat[i,j] = 1;
                        dataGridView.Rows[i].Cells[j].Value = 1;
                    }
                    else
                    {
                        mat[i,j] = 0;
                        dataGridView.Rows[i].Cells[j].Value = 0; 
                    }
                }
            }

            DisplayGraph.PlotGraph(zedGraph, mat);

        }
    }
}
