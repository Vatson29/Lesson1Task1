
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (a <= 0)
Console.WriteLine("Вы ввели не верные данные ");

while (i <= a)
{
    Console.WriteLine(i);
    i = i + 2;
}

