Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0)
Console.WriteLine("Вы ввели отрицательне число ");

int num = 0;

while (num <= a)
{
    Console.WriteLine(num);
    num = num + 2;
}