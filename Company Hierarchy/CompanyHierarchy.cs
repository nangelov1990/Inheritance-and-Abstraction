namespace Company_Hierarchy
{
    using System;
    using Company_Hierarchy.Data;
    using Company_Hierarchy.Data.Enums;

    static class CompanyHierarchy
    {
        static void Main()
        {
            var sale01 = new Sale("Laptop", new DateTime(2015, 1, 30, 17, 45, 34), 1200m);
            var sale02 = new Sale("PC", new DateTime(2015, 1, 30, 12, 14, 34), 800m);
            var sale03 = new Sale("TV", new DateTime(2015, 1, 30, 10, 10, 10), 1500m);
            var sale04 = new Sale("Monitor", new DateTime(2015, 1, 28, 14, 15, 34), 500m);
            var sale05 = new Sale("Printer", new DateTime(2015, 1, 19, 11, 25, 00), 200m);
            var sale06 = new Sale("Laptop", new DateTime(2015, 1, 25, 18, 45, 34), 2000m);
            var sale07 = new Sale("Hi-Fi", new DateTime(2015, 1, 27, 17, 45, 34), 1500m);
            var sale08 = new Sale("PC Wheel", new DateTime(2015, 1, 31, 17, 45, 34), 250m);
            var sale09 = new Sale("Tablet", new DateTime(2015, 1, 26, 15, 34, 34), 600m);
            var sale10 = new Sale("Phone", new DateTime(2015, 1, 22, 13, 54, 34), 800m);
            var sale11 = new Sale("Phable", new DateTime(2015, 1, 24, 18, 12, 34), 900m);
            
            var salesMilanov = new SalesEmployee("Evgeni Milanov", 2, 1500, Departments.Sales, new Sale[] { sale01, sale06, sale11});
            var salesHristenburg = new SalesEmployee("Adi Hristenburg", 3, 1500, Departments.Sales, new Sale[] { sale02, sale07});
            var salesKostadinov = new SalesEmployee("Antonio Kostadinov", 4, 1500, Departments.Sales, new Sale[] { sale03, sale08});
            var salesTucker = new SalesEmployee("Kendall Tucker", 5, 1500, Departments.Sales, new Sale[] { sale04, sale09});
            var salesNikolow = new SalesEmployee("Petar Nikolow", 6, 1500, Departments.Sales, new Sale[] { sale05, sale10});
            
            var project1 = new Project("Android Game", new DateTime(2014, 11, 05), "Chess game", ProjectStates.Open);
            var project2 = new Project("Android App", new DateTime(2014, 12, 15), "Facebook app", ProjectStates.Open);
            var project3 = new Project("Company website", new DateTime(2014, 09, 20), "Online website", ProjectStates.Open);
            var project4 = new Project("Android Game", new DateTime(2014, 12, 25), "Snake 3D game", ProjectStates.Open);
            var project5 = new Project("Android App", new DateTime(2015, 01, 15), "Taxi callup", ProjectStates.Open);
            var project6 = new Project("Java App", new DateTime(2014, 11, 19), "Java extention", ProjectStates.Open);
            var project7 = new Project("Android Game", new DateTime(2014, 10, 08), "Car game", ProjectStates.Open);

            var devMladenov = new Developer("Nikola Mladenov", 7, 3500, Departments.Production, new Project[] { project1, project4, project7 });
            var devBarton = new Developer("Josh Barton", 7, 3500, Departments.Production, new Project[] { project2, project5 });
            var devLesov = new Developer("Philip Lesov", 7, 3500, Departments.Production, new Project[] { project3 });
            var devIvanov = new Developer("Radostin Ivanov", 7, 4000, Departments.Production, new Project[] { project6 });

            devLesov.CloseProject(project3);

            var employees = new Employee[]
            {
                salesHristenburg,
                salesKostadinov,
                salesMilanov,
                salesNikolow,
                salesTucker,
                devBarton,
                devIvanov,
                devLesov,
                devMladenov
            };
            
            var managerAtanasova = new Manager("Katerina Atanasova", 1, 5000, Departments.Accounting, employees);

            Console.WriteLine(managerAtanasova); //Intentionally left the \n for easier comprehension.
        }
    }
}
