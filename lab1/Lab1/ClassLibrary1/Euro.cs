using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Euro : Money
    {
        public Euro(int WholePart, int CoinPart) : base(WholePart, CoinPart) { }
        public override string showMoney()
        {
            return base.showMoney() + "eur";
        }
        public override string ToString()
        {
            return showMoney();
        }
    }
}
