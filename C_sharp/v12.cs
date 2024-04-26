using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace HelloWorld
{

public class Program
{
    public static void Main()
    {
        int[,] labyrinth = new int[100, 100];
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                labyrinth[i, j] = 1; 
            }
        }

        bool pathExists = BFS(labyrinth, new Point(0, 0), new Point(99, 99));
        Console.WriteLine("A path exists between the two cells: " + pathExists);
    }

    public static bool BFS(int[,] labyrinth, Point start, Point end)
    {
        var queue = new Queue<Point>();
        var visited = new bool[labyrinth.GetLength(0), labyrinth.GetLength(1)];

        queue.Enqueue(start);
        visited[start.X, start.Y] = true;

        while (queue.Count > 0)
        {
            var point = queue.Dequeue();

            if (point.Equals(end))
            {
                return true; 
            }

            List<Point> neighbors = new List<Point>
            {
                new Point(point.X - 1, point.Y),
                new Point(point.X + 1, point.Y),
                new Point(point.X, point.Y - 1),
                new Point(point.X, point.Y + 1)
            };

            foreach (var neighbor in neighbors)
            {
                if (neighbor.X >= 0 && neighbor.Y >= 0 && neighbor.X < labyrinth.GetLength(0) && neighbor.Y < labyrinth.GetLength(1) && labyrinth[neighbor.X, neighbor.Y] == 1 && !visited[neighbor.X, neighbor.Y])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor.X, neighbor.Y] = true;
                }
            }
        }

        return false; 
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

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Point p = (Point)obj;
        return (X == p.X) && (Y == p.Y);
    }

    public override int GetHashCode()
    {
        return Tuple.Create(X, Y).GetHashCode();
    }
}





}