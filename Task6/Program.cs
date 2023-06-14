// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = number1%2;
if(result > 0)
{
    System.Console.WriteLine("Введеное Вами число нечётное");
}
else
{
    System.Console.WriteLine("Введеное Вами число четное");
}