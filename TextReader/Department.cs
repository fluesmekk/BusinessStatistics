using System;
using System.Collections.Generic;
using System.Text;

namespace TextReader
{
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Team> Teams { get; set; }

        public Department(string departmentName, List<Team> teams)
        {
            DepartmentName = departmentName;
            Teams = teams;
        }

        public List<float> GetPay()
        {
            List<float> Pay = new List<float>();
            foreach (var team in Teams)
            {
                List<float> teamPay = team.GetPay();
                foreach (var pay in teamPay)
                {
                    Pay.Add(pay);
                }
            }

            return Pay;
        }

        public List<int> GetFractions()
        {
            List<int> fractions = new List<int>();
            foreach (var team in Teams)
            {
                List<int> teamFraction = team.GetFractions();
                foreach (var fraction in teamFraction)
                {
                    fractions.Add(fraction);
                }
            }

            return fractions;
        }
    }
}
