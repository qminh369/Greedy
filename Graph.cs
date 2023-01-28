namespace Greedy
{
    public abstract class Graph
    {
        #region Field
        public int _vertex;
        public LinkedList<int>[] _adj;
        #endregion

        #region Properties
        public int Vertex { get => _vertex; set => _vertex = value; }
        public LinkedList<int>[] Adj { get => _adj; set => _adj = value; }
        #endregion

        public abstract void addEdge(int u, int v);
    }

    public class UndirectedGraph: Graph
    {
        public override void addEdge(int u, int v)
        {
            Adj[v].AddLast(u);
            Adj[u].AddLast(v);
        }
    }

    public class DirectedGraph
    {
        #region Field
        private int _vertex;
        private int _weight;
        #endregion

        #region Properties
        public int Vertex { get => _vertex; set => _vertex = value; }
        public int Weight { get => _weight; set => _weight = value; }
        #endregion
        public void addEdge(int _vertex, int weight)
        {

        }
    }
}
