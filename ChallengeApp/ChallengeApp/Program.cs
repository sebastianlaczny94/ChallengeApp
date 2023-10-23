//var myAge = 33;

using System.ComponentModel.Design;
using System.Formats.Asn1;

// Liczby całkowite
int myAge = 120;
int newMyAge = myAge + 5;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MinValue;
ulong myVar4 = ulong.MaxValue;

// Liczby zmiennoprzecinkowe 
float myVar5 = float.MaxValue;
double myVar6 = double.MaxValue;
decimal myVar7 = decimal.MaxValue;

// Zmienne tekstowe
string name = "Sebastian";
string surname = "Łączny";
string result  = name + surname + myAge;
//Console.WriteLine(result);
var result2 = result.ToArray();
//Console.WriteLine(result2);

// Zmienne logiczne
//bool isActive = true;
var isValid = 7 > 6;
//Console.WriteLine(isValid);

var number1 = 10;
var number2 = 10;

var name2 = "Aadam";
var age = 33;

if(age < 50)
{
    if (name2 == "Adam")
    {
        Console.WriteLine("Zagnieżdzenie, jest adam");
    }
    else
    {
        Console.Write("Nie ma Adama");
    }
}

else if(age > 100)
{
    Console.WriteLine("Adam nie ma 33");
}
else
{
    Console.WriteLine("Zadne z wymienionych");
}
// && || !