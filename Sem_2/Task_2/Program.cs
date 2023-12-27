Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int secondDigit = number/10%10;
    int thirdDigit = number%10;
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}