// +++Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 
   
 int[] GetRandomArr(int size, int start, int end)
 {
               
    int[] RandomArr = new int[size];
        for (int i = 0; i < size; i++)
        {          
         RandomArr[i] = new Random().Next(start, end + 1);
        }
         return RandomArr;
}

 void ShowArray(int[] Array1)
{
     for (int i = 0; i < Array1.Length; i++)
         {
         Console.WriteLine(Convert.ToString(Array1[i]));
        }
}
           
 int Count(int[] myArray2)
     {
     int count = 0;
          for (int i = 0; i < myArray2.Length; i++)
             if (myArray2[i] % 2 == 0)
         {
          count = count + 1;
         }
         return count;
}

     int[] myArray = new int[5];
     myArray = GetRandomArr(5, 100, 999);
     ShowArray(myArray);
     Console.WriteLine("количество четных чисел массива " + Count(myArray));
           
  






// Console.Clear();

// int EvenCount(int[] array)
// {
//     int count = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write($"[{array[i]}, ");
//         else if (i == (array.Length - 1)) Console.Write($"{array[i]}]");
//         else Console.Write($"{array[i]}, ");
//     }
// }

// int[] GetArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int index = 0; index < size; index++)
//     {
//         arr[index] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int GetSize(string text)
// {
//     Console.WriteLine(text);
//     int size = int.Parse(Console.ReadLine());
//     return size;
// }

// int size = GetSize("Введите размер массива:");
// int[] array = GetArray(size, 100, 999);
// PrintArray(array);
// int count = EvenCount(array);
// Console.Write($" -> {count}");




// // +++Задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным
// // элементов массива.

// // [3 7 22 2 78] -> 76
// using System;

// class Program {
//   public static void Main (string[] args) {
//     /*Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//             между максимальным и минимальным элементов массива.
//             [3 7 22 2 78] -> 76
//             */

//             int Find_Min_Max_diff(int[] array)
//             {
//                 int result = 0;
//                 int min = 0;
//                 int max = 0;

//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     if (array[min] > array[i])
//                         min = i;
//                     else if (array[max] < array[i])
//                         max = i;
//                 }
//                 Console.WriteLine("min= " + array[min] + "\tmax= " + array[max]);
//                 if (array[min] > array[max])
//                     result = array[min] - array[max];
//                 else if (array[max] > array[min])
//                     result = array[max] - array[min];
//                 return result;
//             }
//              Console.Write("введите размер массива: ");
//             int size = Convert.ToInt32(Console.ReadLine());
//             int[] array = new int[size];
//             Console.Write("введите минимальное значение: ");
//             int Min = Convert.ToInt32(Console.ReadLine());
//             Console.Write("введите максимальное значение: ");
//             int Max = Convert.ToInt32(Console.ReadLine());
//             int temp = 0;
//             if (Min > Max)
//             {
//                 temp = Max;
//                 Max = Min;
//                 Min = temp;
//             }
//             Random rand = new Random();
//             for (int i = 0; i < array.Length; i++)
//                 array[i] = rand.Next(Min, Max);
//             for (int i = 0; i < array.Length; i++)
//                 Console.Write(array[i] + "\t");
            

//             Console.WriteLine("разница между минимальным и максимальным элементом массива=" + Find_Min_Max_diff(array));
//   }
// }
  