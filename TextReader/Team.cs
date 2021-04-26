using System;
using System.Collections.Generic;
using System.Text;

namespace TextReader
{
    class Team
    {
        public string TeamName { get; set; }
        public List<Employee> Employees { get; set; }

        public Team(string teamName, List<Employee> employees)
        {
            TeamName = teamName;
            Employees = employees;
        }

        public List<float> GetPay()
        {
            List<float> Pay = new List<float>();
            foreach (var employee in Employees)
            {
                List<float> employeePay = employee.GetPayAdjustedForPositionFraction();
                foreach (var pay in employeePay)
                {
                    Pay.Add(pay);
                }
            }

            return Pay;
        }

        public List<int> GetFractions()
        {
            List<int> fractions = new List<int>();
            foreach (var employee in Employees)
            {
                List<int> employeeFractions = employee.GetAvergePositionFraction();
                foreach (var employeeFraction in employeeFractions)
                {
                    fractions.Add(employeeFraction);
                }

            }

            return fractions;
        }
    }
}
