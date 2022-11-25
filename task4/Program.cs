// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.WriteLine("Четные числа: ");
while (index <= n)
{   if (index % 2 == 0)
        {
            Console.WriteLine(index);
        }
    index ++;
}
