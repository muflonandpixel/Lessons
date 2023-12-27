Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=10 && number<=99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit>secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine("Читайте условие задачи!");
}
