﻿Console.WriteLine("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x==0||y==0)
{
    Console.WriteLine("Читайте условие задачи!");
}
else
{
    if (x>0 && y>0)
    {
        Console.WriteLine(1);
    }
    else if (x<0 && y<0)
    {
        Console.WriteLine(3);
    }
    else if (x>0 && y<0)
    {
        Console.WriteLine(4);
    }
    else
    {
        Console.WriteLine(2); 
    }
}
