using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextReader
{
    class Business
    {
        public string BusinessName { get; set; }
        public List<Department> Departments { get; set; }

        public Business(string businessName, List<Department> departments)
        {
            BusinessName = businessName;
            Departments = departments;
        }

        public float CalculateTotalAveragePay()
        {
            List<float> AllEmployeePay = GetAllEmployeePay();
            return AveragePay(AllEmployeePay);
        }

        private float AveragePay(List<float> AllEmployeePay)
        {
            float averagePay = 0;
            foreach (var pay in AllEmployeePay)
            {
                averagePay += pay;
            }

            averagePay = averagePay / AllEmployeePay.Count;
            return averagePay;
        }

        public List<float> GetAllEmployeePay()
        {
            List<float> allEmployeePay = new List<float>();
            foreach (var department in Departments)
            {
                List<float> departmentPay = department.GetPay();
                foreach (var pay in departmentPay)
                {
                    allEmployeePay.Add(pay);
                }
            }

            return allEmployeePay;
        }

        public double AverageEmployeeFraction()
        {
            return GetAllEmployeeFractions().Average();
        }

        private List<int> GetAllEmployeeFractions()
        {
            List<int> fractions = new List<int>();
            foreach (var department in Departments)
            {
                List<int> departmentFractions = department.GetFractions();
                foreach (var departmentFraction in departmentFractions)
                {
                    fractions.Add(departmentFraction);
                }
            }

            return fractions;
        }

        public string getAllDepartmentsStats()
        {
            string allDepartmentsStats = "";
            foreach (var department in Departments)
            {
                allDepartmentsStats += department.getAllTeams();
            }

            return allDepartmentsStats;
        }
    }
}
