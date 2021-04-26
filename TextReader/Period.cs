using System;
using System.Collections.Generic;
using System.Text;

namespace TextReader
{
    class Period
    {
        public DateTime TimeStarted { get; set; }
        public DateTime? TimeStopped { get; set; }
        public int Pay { get; set; }
        public int PositionFraction { get; set; }

        public Period(DateTime timeStarted, DateTime? timeStopped, int pay, int positionFraction)
        {
            TimeStarted = timeStarted;
            TimeStopped = timeStopped;
            Pay = pay;
            PositionFraction = positionFraction;
        }

        public int GetPay()
        {
            return Pay;
        }

        public int GetPositionFraction()
        {
            return PositionFraction;
        }

    }
}
