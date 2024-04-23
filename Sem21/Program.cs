
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Вы ввели число кратное 7 и 23");
}
else
{
    Console.WriteLine("Вы ввели число не кратное 7 и 23");
}