using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Text.Json;
using Newtonsoft.Json;


namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Period periodLars = new Period(new DateTime(2020, 4, 21), new DateTime(2021, 3, 21), 450000, 100);
            //Period periodLars1 = new Period(new DateTime(2021, 3, 21), new DateTime(2021, 4, 20), 400000, 85);
            //Employee lars = new Employee("Lars Larsen", new List<Period> { periodLars, periodLars1 }, false);

            //Period periodOle = new Period(new DateTime(2020, 4, 21), null, 255000, 50);
            //Employee ole = new Employee("Ole Hansen", new List<Period>{ periodOle }, true);

            //Team team1 = new Team("Team 1", new List<Employee> { lars, ole });

            //Period periodPetter = new Period(new DateTime(2019, 4, 21), null, 500000, 100);
            //Employee petter = new Employee("Petter Johansen", new List<Period> { periodPetter }, true);

            //Period periodLarsH = new Period(new DateTime(2021, 4, 21), null, 650000, 100);
            //Employee larsNewTeam = new Employee("Lars Larsen", new List<Period> { periodLarsH }, true);

            //Team team2 = new Team("Team 2", new List<Employee> { petter, larsNewTeam });

            //Department IT = new Department("Avdeling IT", new List<Team> { team1, team2 });

            //Period periodLine = new Period(new DateTime(2018, 1, 13), null, 600000, 100);
            //Employee line = new Employee("Line Olsen", new List<Period> { periodLine }, true);

            //Team team3 = new Team("Team 1", new List<Employee> { line });

            //Department HR = new Department("Avdeling HR", new List<Team> { team3 });

            //Business genericIT = new Business("GenericIT", new List<Department> { IT, HR });

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string jString = JsonSerializer.Serialize(genericIT, options);
            //File.WriteAllText("C:/Users/Theodor/Desktop/JSON/GenericIT.txt", jString);


            //bruker newton sin Json deserializer, og har serializa med stock serializer.
            string json = File.ReadAllText("C:/Users/Theodor/Desktop/JSON/GenericIT.txt");
            Business business = JsonConvert.DeserializeObject<Business>(json);
            BusinessStatistics stats = new BusinessStatistics();

            //Viser hele bedriften
            stats.ShowAverageOfBusiness(business);
            Console.WriteLine();

            //Viser en avdelings gjennomsnittlige verdier
            stats.ShowAverageOfDepartment(business.Departments[0]);
            Console.WriteLine();

            //Viser et teams gjennomsnittlige verdier
            stats.ShowAverageOfTeam(business.Departments[0].Teams[0]);

            //Viser en liste over personer 
            stats.ShowAllEmployees(business);
        }

        

        

        
    }
}
