Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while ((int)number/i>9)
{
    i=i*10;
}
Console.Write((int)number/i);
number = number % i;
i=i/10;
while (number>0)
{
    Console.Write(","+(int)number/i);
    number = number % i;
    i=i/10;
}