using ChallengeApp;

Employee emp1 = new Employee("Tomasz", "Kowalski", 30);
Employee emp2 = new Employee("Marcin", "Wrobel", 22);
Employee emp3 = new Employee("Martyna", "Nowakowska", 19);

emp1.AddScore(5);
emp2.AddScore(2);
emp3.AddScore(2);

emp1.AddScore(7);
emp2.AddScore(10);
emp3.AddScore(6);

emp1.AddScore(8);
emp2.AddScore(9);
emp3.AddScore(10);

emp1.AddScore(8);
emp2.AddScore(2);
emp3.AddScore(1);

emp1.AddScore(2);
emp2.AddScore(10);
emp3.AddScore(5);


var ResultEmp1 = emp1.Result;
var ResultEmp2 = emp2.Result;
var ResultEmp3 = emp3.Result;

var Emp1Data = ($"{emp1.Name} {emp1.Surname} lat {emp1.Age}, wynik {ResultEmp1}");
var Emp2Data = ($"{emp2.Name} {emp2.Surname} lat {emp2.Age}, wynik {ResultEmp2}");
var Emp3Data = ($"{emp3.Name} {emp3.Surname} lat {emp3.Age}, wynik {ResultEmp2}");


List<int> SumUp = new List<int>();
SumUp.Add(ResultEmp1);
SumUp.Add(ResultEmp2);
SumUp.Add(ResultEmp3);

int TopValue = SumUp.Max();


if (TopValue == ResultEmp1)
{
    Console.WriteLine(Emp1Data);
}
else if (TopValue == ResultEmp2)
{
    Console.WriteLine(Emp2Data);
}
else
{
    Console.WriteLine(Emp3Data);
}