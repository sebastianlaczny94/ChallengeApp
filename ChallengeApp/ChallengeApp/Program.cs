var name = "Noemi";
var sex = "Kobieta";
var age = 33;

if (sex == "Kobieta")
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");

    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
        
    else
    {
        Console.WriteLine("Kobieta mająca 30 lub więcej lat");
    }
}
else if (age >= 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}