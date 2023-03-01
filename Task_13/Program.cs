Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
    {
        int third_digit = Third_Digit(number);
        Console.WriteLine($"Третья цифра числа {number} - {third_digit}");
    }
else
    Console.WriteLine("Третьей цифры нет"); 


int Third_Digit(int num)
{
    while(number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    return result;
}

