// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int pow = Convert.ToInt32(Console.ReadLine());
int result = 1;

if(pow < 1) Console.WriteLine("Cтепень должна быть натуральным числом");
else
{
for(int i = 1; i <= pow; i ++)
{
result = result * number;
}
Console.WriteLine(result);
}
