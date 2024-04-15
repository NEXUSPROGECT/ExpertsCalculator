using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExpertsCalculator
{
    internal class Disagreement
    {
        public static void CalculateDisagreement(double[,] dataArray, DataGridView dataGridView, double threshold, PictureBox pictureBox)
        {
            int numExperts = dataArray.GetLength(1);
            int numCriteria = dataArray.GetLength(0);

            // Матрица рассогласования
            double[,] disagreementMatrix = new double[numExperts, numExperts];

            // 1. Делаем матрицу упорядоченности в канонической форме для каждого эксперта
            int[,] canonicalMatrix = new int[numCriteria, numExperts];
            for (int j = 0; j < numExperts; j++)
            {
                for (int i = 0; i < numCriteria; i++)
                {
                    for (int k = 0; k < numCriteria; k++)
                    {
                        canonicalMatrix[i, j] += dataArray[i, j] > dataArray[k, j] ? 1 : dataArray[i, j] < dataArray[k, j] ? -1 : 0;
                    }
                }
            }

            // 2. Мера близости (расстояние) Кемени между ранжированием
            for (int i = 0; i < numExperts; i++)
            {
                for (int j = i + 1; j < numExperts; j++)
                {
                    double distance = 0;
                    for (int k = 0; k < numCriteria; k++)
                    {
                        distance += Math.Abs(canonicalMatrix[k, i] - canonicalMatrix[k, j]);
                    }
                    disagreementMatrix[i, j] = distance / 2; // Мера близости Кемени
                    disagreementMatrix[j, i] = distance / 2;
                }
            }

            // 3. Матрица d преобразованная в матрицу d' (применяем пороговое значение)
            int[,] transformedMatrix = new int[numExperts, numExperts];
            for (int i = 0; i < numExperts; i++)
            {
                for (int j = 0; j < numExperts; j++)
                {
                    transformedMatrix[i, j] = disagreementMatrix[i, j] <= threshold ? 1 : 0;
                }
            }

            // 4. Выводим результаты в DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            for (int j = 0; j < numExperts; j++)
            {
                dataGridView.Columns.Add($"Expert{j}", $"Expert {j + 1}");
            }
            for (int i = 0; i < numExperts; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < numExperts; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = transformedMatrix[i, j] });
                }
                dataGridView.Rows.Add(row);
            }

            // 5. Отображаем результаты в виде графа
            DisplayGraph.DrawDirectedGraph(transformedMatrix, pictureBox);
        }
    }
}
