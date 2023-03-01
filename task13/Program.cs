// Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер цифры для вывода: "); // для данной задачи это число 3
int n = Convert.ToInt32(Console.ReadLine());

int rest = Math.Abs(number);
int i = 0;
while (rest != 0) // определяем количество цифр в числе
{
    rest /= 10;
    i++;
}

if (n < i)
{
    int divider = (int)Math.Pow(10 , i-n);
    int numberDigit = Math.Abs(number) / divider % 10;
    Console.WriteLine($"{n} цифра - {numberDigit}"); 
}
else
{
   Console.WriteLine($"{n} цифры нет"); 
}