namespace Greedy
{
    class Dijkstra
    {
        #region Field
        private static int _vertex = 9;
        #endregion

        #region Properties
        public static int Vertex { get => _vertex; set => _vertex = value; }
        #endregion

        public static int minDistance(int[] _dist, bool[] _sptSet)
        {
            int _min = int.MaxValue;
            int _min_index = -1;

            for (int _vertex = 0; _vertex < Vertex; _vertex++)
            {
                if (_sptSet[_vertex] == false && _dist[_vertex] < _min)
                {
                    _min = _dist[_vertex];
                    _min_index = _vertex;
                }
            }

            return _min_index;
        }

        public void findShortestPath(int[,] _graph, int _src)
        {
            int[] _dist = new int[Vertex];
            bool[] _sptSet = new bool[Vertex];

            for (int i = 0; i < Vertex; i++)
            {
                _dist[i] = int.MaxValue;
                _sptSet[i] = false;
            }

            _dist[_src] = 0;

            for(int count = 0; count < Vertex - 1; count++)
            {
                int u = minDistance(_dist, _sptSet);

                _sptSet[u] = true;

                for (int v = 0; v < Vertex; v++)
                {
                    if (!_sptSet[v] && _graph[u, v] != 0
                        && _dist[u] != int.MaxValue
                        && _dist[u] + _graph[u, v] < _dist[v]) 

                        _dist[v] = _dist[u] + _graph[u, v];
                }
            }

            printSolution(_dist);
        }

        public void printSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance " + "from Source\n");
            for (int i = 0; i < Vertex; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }

    }
}
