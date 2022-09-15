Console.WriteLine("Введите первое число ");
string nameA = Console.ReadLine();
int numberA = Convert.ToInt32(nameA);
Console.WriteLine("Введите второе число ");
string nameB = Console.ReadLine();
int numberB = Convert.ToInt32(nameB);
if (numberB > 0)
{
    double a = Math.Pow(numberA,numberB);
    Console.WriteLine("Натуральная степень первого числа " + a);
}
else
{ 
   Console.WriteLine("Обращаем ваше внимание,  разбирается понятие степени только с натуральным показателем");
}