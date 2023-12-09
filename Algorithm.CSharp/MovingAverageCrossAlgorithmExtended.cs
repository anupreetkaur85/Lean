using System;
using System.Linq;
using QuantConnect.Configuration;
using QuantConnect.Data.Market;
using QuantConnect.Indicators;
using static Python.Runtime.TypeSpec;

namespace QuantConnect.Algorithm.CSharp
{
    public class MovingAverageCrossAlgorithmExtended : MovingAverageCrossAlgorithm
    {
        public override void Initialize()
        {
            // set up our analysis span
            var startDate = UserConfig.GetValue("start-date", new DateTime(2020, 01, 01));
            var endDate = UserConfig.GetValue("end-date", new DateTime(2023, 01, 01));
            SetStartDate(startDate.Year, startDate.Month, startDate.Day);
            SetEndDate(endDate.Year, endDate.Month, endDate.Day);

            // request SPY data with minute resolution
            AddSecurity(SecurityType.Equity, _symbol, Resolution.Minute);

            //// create a 15 day exponential moving average
            //_fast = EMA(_symbol, 15, Resolution.Daily);

            //// create a 30 day exponential moving average
            //_slow = EMA(_symbol, 30, Resolution.Daily);

            //var ribbonCount = 8;
            //var ribbonInterval = 15;
            //_ribbon = Enumerable.Range(0, ribbonCount).Select(x => SMA(_symbol, (x + 1) * ribbonInterval, Resolution.Daily)).ToArray();


        }
    }
}
