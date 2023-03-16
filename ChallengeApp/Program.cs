using ChallengeApp;

var employee = new Employee("Jagoda", "Kot");

employee.AddGrade("k");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(4);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average - {statistics.Average:N2}");
Console.WriteLine($"Min - {statistics.Min}");
Console.WriteLine($"Max - {statistics.Max}");

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("----FOREACH----");
Console.WriteLine($"Average - {statistics1.Average:N2}");
Console.WriteLine($"Min - {statistics1.Min}");
Console.WriteLine($"Max - {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("----FOR----");
Console.WriteLine($"Average - {statistics2.Average:N2}");
Console.WriteLine($"Min - {statistics2.Min}");
Console.WriteLine($"Max - {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("----DO WHILE----");
Console.WriteLine($"Average - {statistics3.Average:N2}");
Console.WriteLine($"Min - {statistics3.Min}");
Console.WriteLine($"Max - {statistics3.Max}");

var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine("----WHILE----");
Console.WriteLine($"Average - {statistics4.Average:N2}");
Console.WriteLine($"Min - {statistics4.Min}");
Console.WriteLine($"Max - {statistics4.Max}");

