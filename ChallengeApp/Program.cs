using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===============================================");
Console.WriteLine("Zakończ wprowadzanie ocen i otrzymaj statystyki - wprowadz 'q'.");
Console.WriteLine("Pracownik: Radek Chojecki");

var employee = new Employee("Radek", "Chojecki");
int index = 1;

while (true)
{
    if(index == 1)
    {
        Console.WriteLine("Podaj ocenę Pracownika:");
    }
    else
    {
        Console.WriteLine("Podaj kolejną ocenę Pracownika:");
    }
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
    index++;
}
if (index == 1)
{
    Console.WriteLine("Brak wprowadzonych ocen:");
}

Console.WriteLine("Statystyka Pracownika: ");
var statistics = employee.GetStatistics();
Console.WriteLine($"Radek Chojecki - Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Radek Chojecki - Average: {statistics.Average:N2}");
Console.WriteLine($"Radek Chojecki - Min: {statistics.Min}");
Console.WriteLine($"Radek Chojecki - Max: {statistics.Max}");


