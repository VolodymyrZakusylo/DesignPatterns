using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dollar : Money
    {
        public Dollar(int WholePart, int CoinPart) : base(WholePart, CoinPart) { }
        public override string showMoney()
        {
            return base.showMoney() + "usd";
        }
        public override string ToString()
        {
            return showMoney();
        }
    }
}
