using System;
using System.Linq;
using System.Diagnostics;

namespace Lab4
{
    class FloydAlgo
    {
		public int Vertices { get; private set; }
        const int INF = short.MaxValue;

		public FloydAlgo() { Vertices = 0; }

		public FloydAlgo(int Vertices)
        {
			this.Vertices = Vertices;
        }

		void _DisplayResult(int[,] result)
		{

			Console.WriteLine("Matricea de adiacenta pentru cele mai mici distante dintre noduri: ");

			for (int i = 0; i < Vertices; i++)
			{
				for (int j = 0; j < Vertices; j++)
				{

					if (result[i, j] == INF)					
						Console.Write("INF ");
					
					else
						Console.Write(result[i, j] + " ");
					
				}

				Console.WriteLine("");
			}
		}

		public void Implement(int[,] graph)
		{
            
            int[,] result = new int[Vertices, Vertices];

            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                    result[i, j] = graph[i, j];
                
            }

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                {
                    for (int k = 0; k < Vertices; k++)
                    {
                        if (result[j, k] > result[j, i] + result[i, k])
                            result[j, k] = result[j, i] + result[i, k];
                        
                    }
                }
            }

            sw.Stop();

            _DisplayResult(result);

            Console.WriteLine("-----------------------------\nElapsed time : " + sw.Elapsed);
        }

		

	}
}
