using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Greedy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region ExchangeMoney
            Console.OutputEncoding = Encoding.UTF8;
            int[] listMoney = new int[10];

            string[] lines = File.ReadAllLines(@"C:\Users\admin\Source\Repos\Greedy\Money.txt");

            int j = 0;
            foreach (string line in lines)
            {
                // Console.WriteLine(line);
                listMoney[j] = Convert.ToInt32(line);
                j++;
            }
            int[] iquantity = new int[10];
            Console.WriteLine("Số tiền cần đổi: ");
            Exchange exchangeMoney = new Exchange(listMoney);
            int moneyExchange = Convert.ToInt32(Console.ReadLine());
            iquantity = exchangeMoney.ExchangeMoney(moneyExchange);
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Số tờ {0}: {1}", listMoney[i], iquantity[i]);
            }
            #endregion

            #region JobScheduling
            /*
            List<Job> jobs = new List<Job>();
            string[] lines = File.ReadAllLines(@"C:\Users\admin\Source\Repos\Greedy\JobSequence.txt");

            foreach (string line in lines)
            {
                string Line = line.Replace("\t", "");
                // Console.WriteLine('\n' + Line);
                jobs.Add(new Job(Line.Substring(0, 6), Convert.ToInt32(Line[6]), Convert.ToInt32(Line.Substring(7, 4))));
            }
            Console.WriteLine("Following is maximum " + "profit sequence of jobs");

            Job job = new Job();

            job.jobScheduling(jobs, 20);
            */
            #endregion

            #region Dijkstra
            /*
            Dijkstra dijkstra = new Dijkstra();
            int[,] graph = new int[50, 50];
            string[] lines = File.ReadAllLines(@"C:\Users\admin\Source\Repos\Greedy\dataDijkstra.txt");

            int i = 0; int j = 0;
            foreach(string line in lines)
            {
                j = 0;
                string[] nums = lines[i].Split(' ');
                foreach(string num in nums) {
                    graph[i, j] = int.Parse(num);
                    j++;
                }
                i++;
            }
            
        
            dijkstra.findShortestPath(graph, 0);
            */
            #endregion

            #region GraphColoring
            /*
            GraphColoring graph = new GraphColoring(10);

            string[] lines = File.ReadAllLines(@"C:\Users\admin\Source\Repos\Greedy\dataGraphColoring.txt");

            foreach (string line in lines)
            {
                string Line = line.Replace("\t", "");
                //Console.WriteLine(Line[0]);
                //Console.WriteLine(Line[1]);

                graph.addEdge(Convert.ToInt32(Line[0]), Convert.ToInt32(Line[1]));
            }
            
            Console.WriteLine("Coloring of graph: ");
            graph.greedyColoring();
            */
            #endregion

        }
    }
}
