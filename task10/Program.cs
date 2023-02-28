//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

// Math.Abs(-5) = 5, возвращает число без знака 
if ((99 < Math.Abs(number)) && (Math.Abs(number) < 1000)) 
{
    int result = Math.Abs((number % 100)/10);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите трехзначное число!!!");
}

