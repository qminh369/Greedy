using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
	public class Prim
	{
        #region Field
        private int _vertex = 5;
        #endregion

        #region Properties
        public int Vertex { get => _vertex; set => _vertex = value; }
        #endregion

        public int minKey(int[] _key, bool[] _mstSet)
		{
			int _min = int.MaxValue;
			int _min_index = -1;

			for (int v = 0; v < _vertex; v++)
				if (_mstSet[v] == false && _key[v] < _min)
				{
					_min = _key[v];
					_min_index = v;
				}

			return _min_index;
		}

		public void printMST(int[] _parent, int[,] _graph)
		{
			Console.WriteLine("Edge \tWeight");
			for (int i = 1; i < _vertex; i++)
				Console.WriteLine(_parent[i] + " - " + i + "\t" + _graph[i, _parent[i]]);
		}

		public void primMST(int[,] _graph)
		{

			// Array to store constructed MST
			int[] _parent = new int[_vertex];

			// Key values used to pick
			// minimum weight edge in cut
			int[] _key = new int[_vertex];

			// To represent set of vertices
			// included in MST
			bool[] _mstSet = new bool[_vertex];

			// Initialize all keys
			// as INFINITE
			for (int i = 0; i < _vertex; i++)
			{
				_key[i] = int.MaxValue;
				_mstSet[i] = false;
			}

			_key[0] = 0;
			_parent[0] = -1;

			for (int count = 0; count < _vertex - 1; count++)
			{
				int u = minKey(_key, _mstSet);
				_mstSet[u] = true;

				for (int v = 0; v < _vertex; v++)
					if (_graph[u, v] != 0 && _mstSet[v] == false
						&& _graph[u, v] < _key[v])
					{
						_parent[v] = u;
						_key[v] = _graph[u, v];
					}
			}

			printMST(_parent, _graph);
		}
	}
}
