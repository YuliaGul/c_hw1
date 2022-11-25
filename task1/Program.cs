// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Первое число больше: ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("Второе число больше: ");
    Console.WriteLine(number2);
}
