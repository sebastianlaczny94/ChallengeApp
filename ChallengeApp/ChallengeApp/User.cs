using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp // przestrzen nazw
{
    public class Employee
    {
        List<int> score = new List<int>();
        //Konstruktor
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        //Pola dostępu property
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        //Metoda zbieranie wyników
        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}

