using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextReader
{
    class BusinessStatistics
    {
        public void ShowAverageOfTeam(Team team)
        {
            float averagePay = team.GetPay().Average();
            Console.WriteLine("Average Pay of " + team.TeamName + " Employees is " + (int)averagePay +
                              " kr per year adjusted for position fraction");
            int employeeCount = team.GetPay().Count;
            Console.WriteLine("The amount of employees is " + employeeCount);
            double averagePositionFraction = team.GetFractions().Average();
            Console.WriteLine("The average position fraction is " + (int)averagePositionFraction + "%");
        }

        public void ShowAverageOfDepartment(Department chosenDepartment)
        {
            float averagePay = chosenDepartment.GetPay().Average();
            Console.WriteLine("Average Pay of " + chosenDepartment.DepartmentName + " Employees is " + (int)averagePay +
                              " kr per year adjusted for position fraction");
            int employeeCount = chosenDepartment.GetPay().Count;
            Console.WriteLine("The amount of employees is " + employeeCount);
            double averagePositionFraction = chosenDepartment.GetFractions().Average();
            Console.WriteLine("The average position fraction is " + (int)averagePositionFraction + "%");
        }

        public void ShowAverageOfBusiness(Business business)
        {
            float averagePay = business.CalculateTotalAveragePay();
            Console.WriteLine("Average Pay of " + business.BusinessName + " Employees is " + (int)averagePay +
                              " kr per year adjusted for position fraction");
            int employeeCount = business.GetAllEmployeePay().Count;
            Console.WriteLine("The amount of employees is " + employeeCount);
            double averagePositionFraction = business.AverageEmployeeFraction();
            Console.WriteLine("The average position fraction is " + (int)averagePositionFraction + "%");
        }
    }
}
