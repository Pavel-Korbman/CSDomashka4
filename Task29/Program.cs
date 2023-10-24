// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void WriteArray(int [] newArray)
{
// int stop = newArray.Length;
  for(int i=0; i<newArray.Length; i++)
  {
  Console.Write(newArray[i]+ ", ");
  }
}
int [] Array = {1, 2, 5, 7, 19};
WriteArray(Array);
Console.WriteLine();
int [] Array1 = {6, 1, 33};
WriteArray(Array1);