using System.Numerics;

Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

return max;





// if (num1 > num2 && num1 > num3)
// {
// Console.WriteLine("Большее число =" + num1);    
// }
// if (num2 > num1 && num2 > num3)
// {
// Console.WriteLine("Большее число =" + num2);    
// }
// if (num3 > num1 && num3 > num2)
// {
// Console.WriteLine("Большее число =" + num3);    
// }