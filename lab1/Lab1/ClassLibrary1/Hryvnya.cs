using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hryvnya : Money
    {
        public Hryvnya(int WholePart, int CoinPart) : base(WholePart, CoinPart) { }
        public override string showMoney()
        {
            return base.showMoney() + "uah";
        }
        public override string ToString()
        {
            return showMoney();
        }
    }
}
