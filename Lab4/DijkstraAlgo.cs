using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Lab4
{
    class DijkstraAlgo
    {
        private bool[] _ifVisited = Array.Empty<bool>();

        public int[] result = Array.Empty<int>();

        public DijkstraAlgo() { }

        public DijkstraAlgo(int size)
        {
            _ifVisited = new bool[size];

            for (int i = 0; i < _ifVisited.Length; i++)
                _ifVisited[i] = false;

            result = new int[size];

            for (int i = 0; i < result.Length; i++)
                result[i] = int.MaxValue;

        }

        private int _MinDistance()
        {
            int min = int.MaxValue, min_index = -1;

            for (int i = 0; i < result.Length; i++)
            {
                if (_ifVisited[i] == false && result[i] <= min)
                {
                    min = result[i];
                    min_index = i;
                }
            }

            return min_index;
        }

        void _PrintSolution()
        {
            Console.WriteLine("Nodul Start : 0");

            Console.WriteLine("Nod \t\t Distanta de la Start : ");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < result.Length; i++)
                Console.Write(i + " \t\t " + result[i] + "\n");
        }

        public void Implement(int[,] graph)
        {
            result[0] = 0;

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                int minDist = _MinDistance();

                _ifVisited[minDist] = true;

                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (!_ifVisited[j] && graph[minDist, j] != 0 && result[minDist] != int.MaxValue && result[minDist] + graph[minDist, j] < result[j])
                        result[j] = result[minDist] + graph[minDist, j];
                }                   
            }
            sw.Stop();

            _PrintSolution();

            Console.WriteLine("-----------------------------\nElapsed time : " + sw.Elapsed);
        }
    }
}
