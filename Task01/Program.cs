// +++Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 
   
 int[] GetArr(int size, int start, int end)
 {
               
    int[] RandomArr = new int[size];
        for (int i = 0; i < size; i++)
        {          
         RandomArr[i] = new Random().Next(start, end + 1);
        }
         return RandomArr;
}

 void PrintArray(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
         {
         Console.WriteLine(arr[i]);
        }
}
           
 int Count(int[] array)
     {
     int count = 0;
          for (int i = 0; i < array.Length; i++)
             if (array[i] % 2 == 0)
         {
          count = count + 1;
         }
         return count;
}

     int[] myArray = new int[4];
     myArray = GetArr(4, 100, 999);
     PrintArray(myArray);
     Console.WriteLine("количество четных чисел - " + Count(myArray));