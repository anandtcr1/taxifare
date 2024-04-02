using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class TaxiFareBand
    {
        public int MilesStart { get; set; }
        public int MilesEnd { get; set; }
        public double Fare { get; set; }
        public int BandOrder { get; set; }

    }
}
