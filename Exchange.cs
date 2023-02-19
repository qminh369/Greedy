using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    internal class Exchange
    {
        public int[] listMoney { get; set; }
        public Exchange(int[] _listMoney)
        {
            listMoney = _listMoney;
        }
        public int[] ExchangeMoney(int _moneyExchange)
        {
            int[] _quantityExchange = new int[listMoney.Length];
            Array.Sort(listMoney);
            for (int i = listMoney.Length - 1; i >= 0; i--)
            {
                _quantityExchange[i] = _moneyExchange / listMoney[i];
                _moneyExchange = _moneyExchange - listMoney[i] * _quantityExchange[i];
            }
            return _quantityExchange;
        }
    }
}
