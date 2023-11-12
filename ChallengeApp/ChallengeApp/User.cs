using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dzień 8 Typy referencyjne i warotściowe


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
        public Employee(string name)
        {
            this.Name = name;
            
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

////TABLICA POWTÓRKA
//int[] grades = new int[5];
//string[] dayofweeks2 = new string[7]; // 1 sposób tablicy

//dayofweeks2[0] = "pon";
//dayofweeks2[1] = "wt";
//dayofweeks2[2] = "sr";

//string[] dayofweeks3 = { "pon", "wt","sr","cz","pt","sob","niedziela" };// 2 sposób tablicy


//for (int i = 0; i < dayofweeks3.Length; i++)
//{

//    if (dayofweeks3[i] == "wt")
//    {
//        Console.WriteLine("We wtorek mam wolne");
//    }
//    Console.WriteLine(dayofweeks3[i]);
//}
//Console.WriteLine(dayofweeks3.Length);

////LISTA POWTÓRKA

//List<string> dayofw = new List<string>();
//dayofw.Add("pon");
//dayofw.Add("wt");
//dayofw.Add("srrr");

//for (var a = 0; a < dayofw.Count; a++)
//{
//    Console.WriteLine(dayofw[a]);
//}

//foreach (var day in dayofw)
//{
//    Console.WriteLine(day);
//}

////KLASY POWTÓRKA

//user user1 = new user("Adam","pass");
//user user2 = new user("Mirek","pass");
//user user3 = new user("Zuza","pass");


//var name = user1.logg;
//user1.addscore2(2);
//var result = user1.Res;
//Console.WriteLine(result);
//class user
//{
//    private List<int> score = new List<int>();

//    public user(string logg, string pass)
//    {
//        this.logg = logg;
//        this.pass = pass;
//    }
//    public string logg { get; private set; }
//    public string pass { get; private set; }
//    public int Res
//    {
//        get
//        {
//            return this.score.Sum();
//        }
//    }    

//    public void addscore2(int num)
//    {
//        //this.score = this.score + score; inna możliwość
//        this.score.Add(num);
//    }

//}
