using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ExpertsCalculator
{
    internal partial class DisplayGraph
    {
        private static int[,] adjacencyMatrix; // Матрица смежности
        private static int numVertices; // Количество вершин
        private const int vertexRadius = 20; // Радиус вершины
        private const int vertexSpacing = 50; // Расстояние между вершинами
        private const int offsetX = 50; // Смещение по оси X
        private const int offsetY = 50; // Смещение по оси Y

        // Статическая функция для создания направленного графа на основе матрицы смежности
        public static void DrawDirectedGraph(int[,] matrix, PictureBox pictureBox)
        {
            numVertices = matrix.GetLength(0);
            adjacencyMatrix = matrix;

            pictureBox.Paint += (sender, e) => DrawGraph(sender, e, pictureBox);
            pictureBox.Invalidate(); // Вызываем перерисовку
        }

        // Статическая функция для отрисовки графа
        private static void DrawGraph(object sender, PaintEventArgs e, PictureBox pictureBox)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Рассчитываем координаты центра окружности
            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;

            // Рассчитываем радиус окружности
            int radius = Math.Min(centerX, centerY) - vertexSpacing;

            // Рисуем вершины равномерно по окружности
            for (int i = 0; i < numVertices; i++)
            {
                double angle = 2 * Math.PI * i / numVertices;
                int x = (int)(centerX + radius * Math.Cos(angle));
                int y = (int)(centerY + radius * Math.Sin(angle));
                DrawVertex(g, i, x, y);
            }

            // Рисуем рёбра
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                    {
                        DrawArrow(g, i, j, centerX, centerY, radius);
                    }
                }
            }
        }

        // Статическая функция для рисования вершины
        private static void DrawVertex(Graphics g, int vertex, int x, int y)
        {
            g.FillEllipse(Brushes.Blue, x - vertexRadius, y - vertexRadius, 2 * vertexRadius, 2 * vertexRadius);
            g.DrawString(vertex.ToString(), SystemFonts.DefaultFont, Brushes.White, x - 6, y - 6);
        }

        // Статическая функция для рисования стрелки
        private static void DrawArrow(Graphics g, int fromVertex, int toVertex, int centerX, int centerY, int radius)
        {
            double fromAngle = 2 * Math.PI * fromVertex / numVertices;
            int fromX = (int)(centerX + radius * Math.Cos(fromAngle));
            int fromY = (int)(centerY + radius * Math.Sin(fromAngle));

            double toAngle = 2 * Math.PI * toVertex / numVertices;
            int toX = (int)(centerX + radius * Math.Cos(toAngle));
            int toY = (int)(centerY + radius * Math.Sin(toAngle));

            Point[] arrowHead = new Point[3];
            arrowHead[0] = new Point(toX, toY);
            arrowHead[1] = new Point(toX - 10, toY - 5);
            arrowHead[2] = new Point(toX - 10, toY + 5);

            g.DrawLine(Pens.Black, fromX, fromY, toX, toY);
            g.FillPolygon(Brushes.Black, arrowHead);
        }
    }
}
