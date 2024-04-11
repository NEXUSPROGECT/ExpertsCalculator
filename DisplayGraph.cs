using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ExpertsCalculator
{
    internal class DisplayGraph
    {
        public static void PlotGraph(ZedGraphControl zedGraphControl, int[,] adjacencyMatrix)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Создание точек (вершин) графа
            PointPairList points = new PointPairList();
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                // Добавляем точку с координатами (i, 0)
                points.Add(i, 0);
            }

            // Добавление соединений между вершинами
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < adjacencyMatrix.GetLength(1); j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
                    {
                        // Добавляем линию между точками (вершинами)
                        LineItem curve = graphPane.AddCurve("", new[] { (double)i, (double)j }, new[] { 0.0, 0.0 }, System.Drawing.Color.Black);
                        curve.Line.Width = 1.5f; // Настройка толщины линии
                    }
                }
            }

            // Настройка отображения графа
            graphPane.Title.Text = "Graph";
            graphPane.XAxis.IsVisible = false;
            graphPane.YAxis.IsVisible = false;

            // Обновление отображения
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
    }
}
