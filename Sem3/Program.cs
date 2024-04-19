Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число");
}


bool b = Convert.ToBoolean (a % 2);

if (b == false)
{
    Console.WriteLine("Вы ввели четное число");
}
else
{
    Console.WriteLine("Вы ввели не четное число");
}