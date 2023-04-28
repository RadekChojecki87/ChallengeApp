using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===============================================");
Console.WriteLine("Zakończ wprowadzanie ocen i otrzymaj statystyki - wprowadz 'q'.");
Console.WriteLine("Pracownik: Radek Chojecki");

Console.WriteLine("wprowadź imię pracownika");
var name = Console.ReadLine();

Console.WriteLine("Wprowadź nazwisko pracownika");
var surname = Console.ReadLine();

var employee = new Employee("name", "surname", "male");
employee.ToString();
//int index = 1;


while (true)
{
    Console.WriteLine("Podaj ocenę Pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception caught: {e.Message}");
    }       
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Radek Chojecki - Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Radek Chojecki - Average: {statistics.Average:N2}");
Console.WriteLine($"Radek Chojecki - Min: {statistics.Min}");
Console.WriteLine($"Radek Chojecki - Max: {statistics.Max}");


