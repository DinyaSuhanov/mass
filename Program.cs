// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // Создание массива
// // int [] arr = int [5];  // сначала тип, затем квадратные скобки, название массива, равно и количество выделяемых ячеек памяти

// using System.Diagnostics;

// int [] arr = new int [5];

// arr[0]=5;
// arr[1]=7;
// arr[2]=5;
// arr[3]=4;
// arr[4]=3;

// Console.WriteLine(arr [0]);
// Console.WriteLine(arr [1]);
// Console.WriteLine(arr [2]);
// Console.WriteLine(arr [3]);
// Console.WriteLine(arr [4]);

// int [] arr2 = new int [5]{1,2,3,4,5};

// int [] arr3 = {1,2,3,4,5};




//                                     z1

// создать массив и заполнить его числами от 1 до n(n - произвольное натуральное число). 
//                     вывести элементы массива на экран.


// int n = 1232;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
//     // Console.Write(arr[i]);
//     // Console.Write(' ');
//     Console.Write($" {arr[i]}");
//     i = i + 1;
// }


//                                      z2

//                  создать массив на 10 произвольных целых чисел.
//                          вывести на экран четные элементы.

// int n = 10;
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int i = 0;

// while (i < n)
// {
//     if (array[i] % 2 == 0)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     i++;

// }


//                             z3
//    дано 10 гирь с разными весом в случайном порядке.
//             определить вес самой тяжелой гири.


// int n = 5;
// int[] array = { 2, 4, 7, 3, 9 };
// int i = 0;
// int max = array[0];

// while (i < n)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i++;
// }
// Console.Write(max);

//                              Z4 как z3 +for
//

// int n = 5;
// int[] array = { 2, 4, 7, 3, 9 };
// int max = array[0];
// for (int j = 0; j < n; j++)
// {
//     if (array[j] > max)
//     {
//         max = array[j];
//     }
// }
// Console.Write(max);

//                              z5 как z4 foreach




int[] array = { 2, 4, 7, 3, 9 };
int max = array[0];

foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }

}
Console.Write(max);