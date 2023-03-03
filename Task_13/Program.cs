Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
    {
        int thirdDigit = ThirdDigit(number);
        Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
    }
else
    Console.WriteLine("Третьей цифры нет"); 


int ThirdDigit(int num)
{
    while(number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    return result;
}

