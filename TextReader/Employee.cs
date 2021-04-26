using System;
using System.Collections.Generic;
using System.Text;

namespace TextReader
{
    class Employee
    {
        public string FullName { get; set; }
        public List<Period> Periods { get; set; }
        public bool CurrentlyEmployed { get; set; }

        public Employee(string fullName, List<Period> periods, bool currentlyEmployed)
        {
            FullName = fullName;
            Periods = periods;
            CurrentlyEmployed = currentlyEmployed;
        }

        public List<float> GetPayAdjustedForPositionFraction()
        {
            List<float> Pay = new List<float>();
            foreach (var period in Periods)
            {
                float actualPay = period.GetPay() / (period.GetPositionFraction() / 100f);
                Pay.Add(actualPay);
            }

            return Pay;
        }

        public List<int> GetAvergePositionFraction()
        {
            List<int> fractions = new List<int>();
            foreach (var period in Periods)
            {
                fractions.Add(period.GetPositionFraction());
            }

            return fractions;
        }
    }
}
