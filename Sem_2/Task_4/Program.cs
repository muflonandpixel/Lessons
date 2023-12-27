Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number/100;
if (a==0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine(a%10);
}
