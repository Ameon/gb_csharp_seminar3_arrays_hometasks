// Задача 3:
// - Задайте массив из вещественных чисел с ненулевой дробной частью.
// - Найдите разницу между максимальным и минимальным элементов массива.
Random random = new Random();

double GenerateRandomDouble(double minValue, double maxValue, int decimalPlaces = 1)
{
  double number = random.NextDouble() * (maxValue - minValue) + minValue;
  return Math.Round(number, decimalPlaces);
}

double RandomNonZeroFraction(double minValue, double maxValue, int decimalPlaces = 1)
{
  double number;
  do
  {
    number = GenerateRandomDouble(minValue, maxValue, decimalPlaces);
  } while (number == Math.Floor(number));
  return number;
}

double[] CreateRandomArray(int size, double minValue, double maxValue)
{
  double[] array = new double[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = RandomNonZeroFraction(minValue, maxValue);
  }
  return array;
}

void PrintArray(double[] array)
{
  Console.Write("Массив: ");
  foreach (double number in array)
  {
    Console.Write(number + " ");
  }
  Console.WriteLine();
}

double[] GetMaxMinRange(double[] array, int decimalPlaces = 1)
{

  double maxElement = array[0];
  double minElement = array[0];

  foreach (double number in array)
  {
    if (number > maxElement)
    {
      maxElement = number;
    }
    if (number < minElement)
    {
      minElement = number;
    }
  }

  double range = Math.Round(maxElement - minElement, decimalPlaces);
  return new double[] { maxElement, minElement, range };
}

int size = 5;

double minValue = 1.0;
double maxValue = 2.0;


double[] array = CreateRandomArray(size, minValue, maxValue);

PrintArray(array);
var result = GetMaxMinRange(array);
Console.WriteLine($"Решение: {result[0]} - {result[1]} = {result[2]}");
Console.WriteLine("Результат: Разница между максимальным и минимальным элементами: " + result[2]);

// double maxElement = array[0];
// double minElement = array[0];

