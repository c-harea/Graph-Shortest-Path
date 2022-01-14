using System;
using System.Linq;

namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;



            int[,] dGraph1 = new int[,] {   { 0, 28, 0, 0, 0, 10, 0  },
                                          { 28, 0, 16, 8, 5, 0, 14 },
                                          { 0, 0 , 0, 12, 0, 0, 0  },
                                          { 0, 0, 12, 0, 22, 0, 18 },
                                          { 0, 0, 0, 22, 0, 25, 24 },
                                          { 10, 0, 0, 0, 25, 0, 0  },
                                          { 0, 14, 0, 18, 24, 0, 0 }};

            int[,] fGraph1 = new int[,] {  { 0, 28, short.MaxValue, short.MaxValue, short.MaxValue, 10, short.MaxValue  },
                                          { short.MaxValue, 0, 16, 8, 5, short.MaxValue, 14 },
                                          { short.MaxValue, short.MaxValue , 0, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue  },
                                          { short.MaxValue, short.MaxValue, 12, 0, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, short.MaxValue, short.MaxValue, 22, 0, 25, 24 },
                                          { 10, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 0, short.MaxValue  },
                                          { short.MaxValue, 14, short.MaxValue, 18, short.MaxValue, short.MaxValue, 0 }};

            int[,] dGraph2 = new int[,] { { 0, 3, 4, 0, 0, 0, 0, 2, 0, 0, 0 },
                                          { 3, 0, 1, 0, 0, 3, 2, 0, 0, 0, 5 },
                                          { 4, 1, 0, 2, 7, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 2, 0, 1, 0, 0, 0, 0, 0, 2 },
                                          { 0, 0, 7, 1, 0, 0, 0, 0, 0, 0, 3 },
                                          { 0, 3, 0, 0, 0, 0, 6, 2, 2, 3, 2 },
                                          { 0, 2, 0, 0, 0, 6, 0, 5, 0, 0, 0 },
                                          { 2, 0, 0, 0, 0, 2, 5, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 0 },
                                          { 0, 0, 0, 0, 0, 3, 0, 0, 1, 0, 1 },
                                          { 0, 5, 0, 2, 3, 2, 0, 0, 0, 1, 0 } };

            

            int[,] fGraph2 = new int[,] { { 0, 3, 4, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 2, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, 0, 1, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { 4, 1, 0, 2, 7, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, short.MaxValue, 2, 0, 1, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 2 },
                                          { short.MaxValue, short.MaxValue, 7, 1, 0, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, 3, short.MaxValue, short.MaxValue, short.MaxValue, 0, 6, 2, 2, short.MaxValue, 2 },
                                          { short.MaxValue, 2, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 0, 5, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 2, 5, 0, short.MaxValue, short.MaxValue, short.MaxValue },
                                          { short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 2, short.MaxValue, short.MaxValue, 0, 1, short.MaxValue },
                                          { short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, short.MaxValue, 3, short.MaxValue, short.MaxValue, 1, 0, short.MaxValue },
                                          { short.MaxValue, 5, short.MaxValue, 2, 3, 2, short.MaxValue, short.MaxValue, short.MaxValue, 1, 0 } };


            DisplayGraph.CreateDotFile(dGraph1, isDirected : false);
            DisplayGraph.GeneratePng();

            //FloydAlgo floydAlgo = new FloydAlgo(fGraph2.GetLength(0));
            //floydAlgo.Implement(fGraph2);

            //DijkstraAlgo dijkstra = new DijkstraAlgo(dGraph2.GetLength(0));
            //dijkstra.Implement(dGraph2);

        }
    }
}