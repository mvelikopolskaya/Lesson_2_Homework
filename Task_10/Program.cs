Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100 && number < 999)
    {int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");
    }
else
    Console.WriteLine("Ошибка ввода"); 


    int SecondDigit(int num)
    {
        int result = number / 10 % 10;;
        return result;
    }