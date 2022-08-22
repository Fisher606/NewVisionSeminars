

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите размер массива по вертикали m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива по горизонтали n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateDoubleArray(array);

WriteArray(array);

Console.WriteLine();

void CreateDoubleArray(double[,] array)         //Метод создания массива
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){              //Метод написания массива
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}




// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine($"Задача 50");

Console.Write("\nMассив задается предшествующей задачей.\n");
Console.Write("Разделяя запятой, введите координаты элемента: ");

string? positionElement = Console.ReadLine();
positionElement = RemovSpaces(positionElement);
int[] position = ParsString(positionElement);

if(position[0] <= m 
&& position[1] <= n 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"В массиве нет такого элемента.");

int[] ParsString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("\nMассив задается предшествующей задачей 47, с трансформацией double в int32.\n");

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayAll(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое столбцов:\n");         //Вывод среднего арефмитического столбцами построчно с присвоением номера столбца
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"Столбец № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayAll (double[,] array)           //Трансформация массива целиком
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}
