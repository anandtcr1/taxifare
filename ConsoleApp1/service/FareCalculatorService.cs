using ConsoleApp1.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.service
{
    public class FareCalculatorService
    {
        List<TaxiFareBand> taxiFareBandList = new List<TaxiFareBand>();
        public double CalculateFare(int distance)
        {
            double fare = 0;

            foreach (var band in taxiFareBandList.OrderBy(x => x.BandOrder).ToList())
            {
                if (distance == 0)
                {
                    break;
                }
                var deltaDistance = 0;
                if (distance >= band.MilesEnd)
                {
                    deltaDistance = band.MilesEnd;
                }
                else
                {
                    deltaDistance = distance;
                }
                fare += deltaDistance * band.Fare;
                distance = distance - deltaDistance;
            }

            return fare;
        }

        public void initializeFareBand()
        {
            var band1 = new TaxiFareBand()
            {
                MilesStart = 0,
                MilesEnd = 1,
                Fare = 10,
                BandOrder = 1
            };

            taxiFareBandList.Add(band1);

            var band2 = new TaxiFareBand()
            {
                MilesStart = 1,
                MilesEnd = 6,
                Fare = 2,
                BandOrder = 2
            };

            taxiFareBandList.Add(band2);

            var band3 = new TaxiFareBand()
            {
                MilesStart = 6,
                MilesEnd = 16,
                Fare = 3,
                BandOrder = 3
            };

            taxiFareBandList.Add(band3);

            var band4 = new TaxiFareBand()
            {
                MilesStart = 16,
                MilesEnd = int.MaxValue,
                Fare = 1,
                BandOrder = 4
            };

            taxiFareBandList.Add(band4);
        }
    }
}
