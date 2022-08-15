/*
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите желаемое количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNum = new int[m];

void InputNum(int m){                       //Метод ввода чисел
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNum[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int NumComparison(int[] massiveNum)         //Метод сравнения чисел
{
  int count = 0;
  for (int i = 0; i < massiveNum.Length; i++)
  {
    if(massiveNum[i] > 0 ) count += 1; 
  }
  return count;
}

InputNum(m);

Console.WriteLine($"Вы ввели чисел больше 0: {NumComparison(massiveNum)} ");



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){                       //Метод ввода значений
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите значения {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)              //Метод решения уравнений
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)            //Метод определения пересечения или паралельности или совпадения прмых
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nДанные прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nДанные прямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nКоордината пересечения точки заданных прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);

*/
