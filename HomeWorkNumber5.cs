/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[6];

void FillArray(int[] array, int min, int max){          //Метод заполнения массива
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){                           //Метод написания массива
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int Quantity(int[] array){                      //Метод определения количества четных чисел
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = Quantity(numbers);
Console.WriteLine($"Четных чисел в массиве {quantity}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите число элементов из которых будет состоять массив ");
int number = Convert.ToInt32(Console.ReadLine()); 

int RNDNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sum = 0;
  Console.Write("Ваш массив ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + randomNumbers[i];
      }
    }
  return sum;
  }

int rndNumbers =  RNDNumbers(number, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {rndNumbers}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayNumbers = new double[10];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double decisionMinMax = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между между минимальным ({minNumber}) и максимальным({maxNumber}) элементами будет равна {decisionMinMax}");

  */