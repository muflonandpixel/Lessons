Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1%number2==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine($"нет, {number1%number2}");
}