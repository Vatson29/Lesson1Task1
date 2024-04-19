Console.WriteLine("Введите число 1");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
Console.WriteLine("Большее число = " + firstNumber + ", а меньшее =" + secondNumber);    
//Console.WriteLine("Меньшее " + num2);    
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("Числа равны");    
}
else
{
    Console.WriteLine("Большее число = " + secondNumber + ", а меньшее =" + firstNumber);    
}


