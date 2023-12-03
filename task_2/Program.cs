// Задача 2:
// - Задайте массив на 10 целых чисел.
// - Напишите программу, которая определяет количество 
//   чётных чисел в массиве.

int[] array = new int[10];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
  array[i] = random.Next(1, 21);
}

Console.WriteLine("Задание № 2");
Console.Write("Массив: ");
foreach (int number in array)
{
  Console.Write(number + " ");
}
Console.WriteLine();

int evenCount = 0;
foreach (int number in array)
{
  if (number % 2 == 0)
  {
    evenCount++;
  }
}

Console.Write("Количество четных чисел в массиве: " + evenCount);
