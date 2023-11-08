using ChallengeApp;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

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

emp1.AddScore(100);
emp2.AddScore(2);
emp3.AddScore(1);

emp1.AddScore(2);
emp2.AddScore(10);
emp3.AddScore(5);


List<Employee> Users = new List<Employee>()
{
    emp1,emp2,emp3
};



int maxResult = -1;
Employee EmpMaxValue = null;
foreach (var user in Users)
{
    if(user.Result > maxResult )
    {
        EmpMaxValue = user;
        maxResult = user.Result;  
    }
    
}

Console.WriteLine($"{maxResult}, {EmpMaxValue.Name}");
