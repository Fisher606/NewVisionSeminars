/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Для определения суммы цифр ведите число : ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num){
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNum = SumNum(num);
Console.WriteLine("Сумма цифр : " + sumNum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Через запятую введите числа : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // Запятая для обозначения конца строки

// Метод для удаления пробелов из строки 
string DeleteSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  Метод для проверки на правильность ввода 
void ErrorCheck (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Введите корректные значения, а именно цифры!");

      }
}

// Метод для создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];   

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      ErrorCheck(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNumbers;
}

// Метод для вывода массива
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = DeleteSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);

*/