int number = 20051;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] numbers = new int[10];

numbers[0] = 0;
numbers[1] = 0;
numbers[2] = 0;
numbers[3] = 0;
numbers[4] = 0;
numbers[5] = 0;
numbers[6] = 0;
numbers[7] = 0;
numbers[8] = 0;
numbers[9] = 0;

int i = 0;
foreach (char letter in letters)
{

    if (letter == '0')
    {
        numbers[0]++;
    }
    else if (letter == '1')
    {
        numbers[1]++;
    }
    else if (letter == '2')
    {
        numbers[2]++;
    }
    else if (letter == '3')
    {
        numbers[3]++;
    }
    else if (letter == '4')
    {
        numbers[4]++;
    }
    else if (letter == '5')
    {
        numbers[5]++;
    }
    else if (letter == '6')
    {
        numbers[6]++;
    }
    else if (letter == '7')
    {
        numbers[7]++;
    }
    else if (letter == '8')
    {
        numbers[8]++;
    }
    else if (letter == '9')
    {
        numbers[9]++;
    }
}
foreach (var num in numbers)
{
    if (i == 0)
    {
        Console.WriteLine($"Wynik dla {number}:");
    }
    Console.WriteLine($"{i}> {num}");
    i++;
}

