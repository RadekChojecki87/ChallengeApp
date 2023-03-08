using ChallengeApp;

var employee1 = new Employee("Jagoda", "Kot");
var employee2 = new Employee("Wiktor", "Pływak");

employee1.AddGrade(2);
employee1.AddGrade(4);
employee1.AddGrade(6);

employee2.AddGrade(8);
employee2.AddGrade(6);
employee2.AddGrade(7);

var statistics1 = employee1.GetStatistics();
var statistics2 = employee2.GetStatistics();

Console.WriteLine($"Average - Jagoda Kot: {statistics1.Average:N2}");
Console.WriteLine($"Min - Jagoda Kot: {statistics1.Min}");
Console.WriteLine($"Max - Jagoda Kot: {statistics1.Max}");

Console.WriteLine($"Average - Wiktor Pływak: {statistics2.Average:N2}");
Console.WriteLine($"Min - Wiktor Pływak: {statistics2.Min}");
Console.WriteLine($"Max - Wiktor Pływak: {statistics2.Max}");