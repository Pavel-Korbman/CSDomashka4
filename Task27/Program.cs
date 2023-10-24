// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number =Math.Abs(Convert.ToInt32(Console.ReadLine()));

int CountNumbers(int newNumber)
{
   int count = 0;
    while(newNumber > 0)
    {
        newNumber/=10;
        count++;
    }
    return count-1;
}

int SumNumbers(int newNum)
{
    int sum = 0;
    for(int i=0; i<=CountNumbers(newNum); i++)
    {
        
        sum += newNum / (int)Math.Pow(10, CountNumbers(newNum));
        newNum %= (int)Math.Pow(10, CountNumbers(newNum));
    }
        return sum + newNum;
}

Console.WriteLine(SumNumbers(number));
