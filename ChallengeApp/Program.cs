var name = "Karolina";
bool female = true;
var age = 36;

if (female && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Karolina" && age == 36)
{
    Console.WriteLine("Karolina, 36 lat");
}
else if (!female && age < 20)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Ktoś inny");
}