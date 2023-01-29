using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class Job
    {
        #region Field
        private char _id;
        private int _deadline;
        public int _profit;
        #endregion     

        #region Properties
        public char Id { get => _id; set => _id = value; }
        public int Deadline { get => _deadline; set => _deadline = value; }
        public int Profit { get => _profit; set => _profit = value; }
        #endregion

        #region Constructor
        public Job() { }

        public Job(char _id, int _deadline, int _profit)
        {
            this._id = _id;
            this._deadline = _deadline;
            this._profit = _profit;
        }
        #endregion

        public void jobScheduling(List<Job> _jobs, int t)
        {
            int _jobs_length = _jobs.Count();

            JobProfit _jobProfit = new JobProfit();
            // Sort all jobs according to decreasing order of profit
            _jobs.Sort(_jobProfit);

            // To keep track of free time slots
            bool[] _result = new bool[t];

            // To store result (Sequence of jobs)
            char[] _job = new char[t];

            for (int i = 0; i < _jobs_length; i++)
            {
                for (int j = Math.Min(t - 1, _jobs[i]._deadline - 1);
                     j >= 0; j--)
                {
                    if (_result[j] == false)
                    {
                        _result[j] = true;
                        _job[j] = _jobs[i]._id;
                        break;
                    }
                }
            }

            foreach (char jb in _job) { Console.Write(jb + " "); }
            Console.WriteLine();

        }
        
    }

    class JobProfit : IComparer<Job>
    {
        public int Compare(Job x, Job y)
        {
            if (x._profit == 0 || y._profit == 0)
            {
                return 0;
            }

            return (y._profit).CompareTo(x._profit);
        }
    }


}
