Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100 && number < 999)
    {int second_digit = Second_Digit(number);
    Console.WriteLine($"Вторая цифра числа {number} - {second_digit}");
    }
else
    Console.WriteLine("Ошибка ввода"); 


    int Second_Digit(int num)
    {
        int result = number / 10 % 10;;
        return result;
    }