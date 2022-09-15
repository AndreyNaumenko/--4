Console.WriteLine("Введите число ");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int sum = 0;
if (number < 0)
{
    number = number * -1;
}
while (number > 0)
{
    int numberA = number % 10;
    sum = sum + numberA;
    number = number / 10;
}
Console.WriteLine("Сумма цифр в числе " + sum);
