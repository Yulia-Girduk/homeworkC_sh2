 // Напишите программу, которая принимает на вход цифру, 
 // обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число для определения дня: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((0 < number) && (number < 8))
{
    if ((number == 6) || (number == 7))
    {
        Console.WriteLine("Выходной ");
    }
    else
    {
        Console.WriteLine(" Рабочий ");
    }
}
else
{
    Console.WriteLine($" Такого дня недели не существует {number}!!!");
}

