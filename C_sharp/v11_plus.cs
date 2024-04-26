using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        private static readonly int[] RowOffsets = { -1, 1, 0, 0 };
        private static readonly int[] ColOffsets = { 0, 0, -1, 1 };
        private static readonly char[] Directions = { 'U', 'D', 'L', 'R' };

        public static void Main(string[] args)
        {
            int[,] labyrinth = {
                { 1, 0, 1, 1, 1 },
                { 1, 1, 1, 0, 1 },
                { 0, 1, 0, 1, 1 },
                { 1, 1, 1, 1, 0 },
                { 1, 1, 1, 1, 1 }
            };

            var path = BFS(labyrinth, new Point(0, 0), new Point(labyrinth.GetLength(0) - 1, labyrinth.GetLength(1) - 1));

            if (path.Count > 0)
            {
                Console.WriteLine("Shortest path: " + string.Join("", path));
            }
            else
            {
                Console.WriteLine("No path found.");
            }
        }

        private static bool IsValid(int row, int col, int[,] labyrinth, bool[,] visited)
        {
            int numRows = labyrinth.GetLength(0);
            int numCols = labyrinth.GetLength(1);
            return row >= 0 && row < numRows && col >= 0 && col < numCols && labyrinth[row, col] == 1 && !visited[row, col];
        }

        private static List<char> BFS(int[,] labyrinth, Point start, Point end)
        {
            var queue = new Queue<Point>();
            var visited = new bool[labyrinth.GetLength(0), labyrinth.GetLength(1)];
            var prev = new Point[labyrinth.GetLength(0), labyrinth.GetLength(1)];

            queue.Enqueue(start);
            visited[start.X, start.Y] = true;

            while (queue.Count > 0)
            {
                var point = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int newRow = point.X + RowOffsets[i];
                    int newCol = point.Y + ColOffsets[i];

                    if (IsValid(newRow, newCol, labyrinth, visited))
                    {
                        queue.Enqueue(new Point(newRow, newCol));
                        visited[newRow, newCol] = true;
                        prev[newRow, newCol] = point;
                    }
                }
            }

            return ConstructPath(prev, start, end);
        }

        private static List<char> ConstructPath(Point[,] prev, Point start, Point end)
        {
            var path = new List<char>();
            for (Point at = end; at != null; at = prev[at.X, at.Y])
            {
                if (prev[at.X, at.Y] != null)
                {
                    int dx = at.X - prev[at.X, at.Y].X;
                    int dy = at.Y - prev[at.X, at.Y].Y;
                    if (dx == 1) path.Add('D');
                    else if (dx == -1) path.Add('U');
                    else if (dy == 1) path.Add('R');
                    else if (dy == -1) path.Add('L');
                }
            }
            path.Reverse();
            return path;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
