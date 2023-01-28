namespace Greedy
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Dijkstra
            /*
            Dijkstra dijkstra = new Dijkstra();
            int[,] graph = new int[,] {{  0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                        { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                        { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                        { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                        { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                        { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                        { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                        { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                        { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            
            dijkstra.findShortestPath(graph, 0);
            */
            #endregion


            #region GraphColoring
            /*
            GraphColoring graph = new GraphColoring(5);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(1, 2);
            graph.addEdge(1, 3);
            graph.addEdge(2, 3);
            graph.addEdge(3, 4);

            Console.WriteLine("Coloring of graph: ");
            graph.greedyColoring();
            */
            #endregion


            #region DijkstraAdjList
            DijkstraAdjList dijkstraAdjList = new DijkstraAdjList();

            int vertex = 9;
            List<List<AdjListNode>> graph = new List<List<AdjListNode>>();

            for (int i = 0; i < vertex; i++)
            {
                graph.Add(new List<AdjListNode>());
            }

            int source = 0;
            graph[0].Add(new AdjListNode(1, 4));
            graph[0].Add(new AdjListNode(7, 8));
            graph[1].Add(new AdjListNode(2, 8));
            graph[1].Add(new AdjListNode(7, 11));
            graph[1].Add(new AdjListNode(0, 7));
            graph[2].Add(new AdjListNode(1, 8));
            graph[2].Add(new AdjListNode(3, 7));
            graph[2].Add(new AdjListNode(8, 2));
            graph[2].Add(new AdjListNode(5, 4));
            graph[3].Add(new AdjListNode(2, 7));
            graph[3].Add(new AdjListNode(4, 9));
            graph[3].Add(new AdjListNode(5, 14));
            graph[4].Add(new AdjListNode(3, 9));
            graph[4].Add(new AdjListNode(5, 10));
            graph[5].Add(new AdjListNode(4, 10));
            graph[5].Add(new AdjListNode(6, 2));
            graph[6].Add(new AdjListNode(5, 2));
            graph[6].Add(new AdjListNode(7, 1));
            graph[6].Add(new AdjListNode(8, 6));
            graph[7].Add(new AdjListNode(0, 8));
            graph[7].Add(new AdjListNode(1, 11));
            graph[7].Add(new AdjListNode(6, 1));
            graph[7].Add(new AdjListNode(8, 7));
            graph[8].Add(new AdjListNode(2, 2));
            graph[8].Add(new AdjListNode(6, 6));
            graph[8].Add(new AdjListNode(7, 1));

            int[] distance = dijkstraAdjList.dijkstra(vertex, graph, source);
            // Printing the Output
            Console.WriteLine("Vertex " + " Distance from Source");
            for (int i = 0; i < vertex; i++)
            {
                Console.WriteLine("{0}             {1}", i, distance[i]);
            }
            #endregion

        }
    }
}
