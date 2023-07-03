using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===============================================");
Console.WriteLine("Zakończ wprowadzanie ocen i otrzymaj statystyki - wprowadz 'q'.");
Console.WriteLine("Pracownik: Radek Chojecki");

//Console.WriteLine("wprowadź imię pracownika");
//var name = Console.ReadLine();

//Console.WriteLine("Wprowadź nazwisko pracownika");
//var surname = Console.ReadLine();
var employee = new EmployeeInMemory("Radek", "Chojecki");

employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano nową ocenę");
}

employee.GradeAdded -= EmployeeGradeAdded;

employee.AddGrade(5);

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();


//var statistics = employee.GetStatistics();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli koniec, nacisnij 'q/Q') :");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


Console.WriteLine($"Radek Chojecki - Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Radek Chojecki - Average: {statistics.Average:N2}");
Console.WriteLine($"Radek Chojecki - Min: {statistics.Min}");
Console.WriteLine($"Radek Chojecki - Max: {statistics.Max}");