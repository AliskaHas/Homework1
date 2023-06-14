// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 - number2;
if(result > 0)
{
     System.Console.WriteLine("Первое число больше второго на " + result);
}
else if(result < 0)
{
    System.Console.WriteLine("Второе число больше первого на " + -result);
}
else
{
    System.Console.WriteLine("Неожиданно Ваши первое и второе числа равны!");
}