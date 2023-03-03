Console.WriteLine("Является ли день выходным?");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

bool weekday = Weekend(DayOfWeek);
if (Weekend(DayOfWeek) == true) Console.WriteLine("Да");
else if (Weekend(DayOfWeek) == false) Console.WriteLine("Нет");
else if (DayOfWeek > 5 && DayOfWeek < 7) Console.WriteLine("Ошибка ввода");

bool Weekend(int day)
{
    if(DayOfWeek > 5 && DayOfWeek < 7) return true; 
    
    return false;
    
}