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
            GraphPane pane = new GraphPane();
            pane.Title.Text = "Граф на основе матрицы смежности";
            pane.XAxis.Title.Text = "X";
            pane.YAxis.Title.Text = "Y";

            // Добавляем точки на плоскость
            PointPairList pointList = new PointPairList();
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                double x = Math.Cos(2 * Math.PI * i / adjacencyMatrix.GetLength(0));
                double y = Math.Sin(2 * Math.PI * i / adjacencyMatrix.GetLength(0));
                pointList.Add(x, y);
            }

            // Добавляем точки на плоскость
            pane.AddCurve("Вершины", pointList, System.Drawing.Color.Red, SymbolType.Circle);

            // Добавляем ребра на граф
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < adjacencyMatrix.GetLength(1); j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                    {
                        PointPairList edgePoints = new PointPairList();
                        edgePoints.Add(pointList[i]);
                        edgePoints.Add(pointList[j]);
                        pane.AddCurve("", edgePoints, System.Drawing.Color.Black, SymbolType.None);
                    }
                }
            }
            zedGraphControl.GraphPane = pane;
        }
    }
}
