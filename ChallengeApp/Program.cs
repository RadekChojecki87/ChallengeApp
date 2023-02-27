using ChallengeApp;

Employee employee1 = new Employee("Wiktor", "Gracz", 12);
Employee employee2 = new Employee("Jagoda", "Kasztan", 12);
Employee employee3 = new Employee("Karolina", "Kot", 36);

employee1.AddScore(9);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(7);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult) 
    {
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}
Console.WriteLine("Pracownikiem z największą ilością punktów jest: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + maxResult + " " + "punktów");