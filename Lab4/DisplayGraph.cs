using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lab4
{
    static class DisplayGraph
    {
        private static int[,] _GetDisplayableGraph(in int[,] graph)
        {
            int[,] graphToBeDisplayed = new int[graph.GetLength(0), graph.GetLength(1)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] == graph[j, i])
                        graphToBeDisplayed[j, i] = 0;


                    graphToBeDisplayed[i, j] = graph[i, j];

                }
            }

            return graphToBeDisplayed;
        }

        public static void CreateDotFile(in int[,] graph, bool isDirected)
        {
            string path = @"E:\c# projects\APA Lab4\Lab4\Lab4\graph.dot";

            FileStream file = File.Create(path);
            file.Close();

            using StreamWriter sw = new StreamWriter(path);

            if (isDirected)
            {
                sw.WriteLine("digraph G {");


                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    for (int j = 0; j < graph.GetLength(1); j++)
                    {
                        if (graph[i, j] == 0 || graph[i, j] == short.MaxValue)
                            continue;

                        sw.WriteLine($" {i} -> {j} [label={(char)34}{graph[i, j]}{(char)34}]");
                    }
                }

                sw.WriteLine(0 + " [style=filled, fillcolor=yellow]");

                sw.WriteLine("}");

                return;
            }

            int[,] graphToBeDisplayed = _GetDisplayableGraph(graph);

            sw.WriteLine("graph G {");


            for (int i = 0; i < graphToBeDisplayed.GetLength(0); i++)
            {
                for (int j = 0; j < graphToBeDisplayed.GetLength(1); j++)
                {
                    if (graphToBeDisplayed[i, j] == 0 )
                        continue;

                    sw.WriteLine($" {i} -- {j} [label={(char)34}{graphToBeDisplayed[i, j]}{(char)34}]");
                }
            }

            sw.WriteLine(0 + " [style=filled, fillcolor=yellow]");

            sw.WriteLine("}");
        }

        public static void GeneratePng()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = "dot -Tpng graph.dot -o graph_dot.png",
                WorkingDirectory = @"E:\c# projects\APA Lab4\Lab4\Lab4",
                CreateNoWindow = true
            };

            Process.Start(startInfo);

            Thread.Sleep(1000);
            Process.Start("explorer.exe", @"E:\c# projects\APA Lab4\Lab4\Lab4\graph_dot.png");
        }

    }
}
