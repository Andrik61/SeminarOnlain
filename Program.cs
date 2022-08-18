// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//  int A = Convert.ToInt32(Console.ReadLine());//[1,A]
// //4 -> от 1 до 4 = 1+2+3+4
// //  for ( начало; условие; увеличение счетчика)
// int sum = 0; //Сумма чисел - изначально 0
// for (int i = 1; i <= A; i++)
// {
//     sum += i; // sum = sum + 1
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");

// 2. Методы
// Методы - подпрограмма, которая выполняет рутинный код
// Заполнить 50 массивов: если есть метод, он вызывается 50 раз
// 50 циклов- for

// тип возвращаемого значения (int,double,stringh)
// type NameMethod (pframs)
// int-CaLcslute (int a, int b)
// int A =Convert.ToInt32(Console.ReadLine()); //[1;A]
// int GetSumNumbers(int number)
// {
//     //While
//     int sum = 0; // Результат
//     int start = 1; // начало нашего цикла
//     while (start <= number) // [1;A]
//     {
//         sum += start; // sum =sum + start
//         start++; // start = start + 1
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");

// 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2                      
// 89126 -> 5

// int num = Convert.ToInt32(Console.ReadLine());
// int GetCountNumbers(int number)
// {
//     int count = 0; // счетчик
//     while (number > 0)
//     {
//         count++;//count = count + 1
//         number /= 10; // Деление на 10
//     }
//     return count;
// }

// Console.WriteLine($"Количество чисел: {GetCountNumbers(num)}");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// N! = 1 * 2 * ... *N

// int num = Convert.ToInt32(Console.ReadLine());

// int GetMultiply (int number)
// {
//     int result = 1; // 2*0 = 2; при умножении указываем 1: любое число на 1 = число
//     // Multiply[1;N]
//     for (int i = 1; i <= number; i++)
//     {
//         result *= i;
//     }
//     return result;
// }
// System.Console.WriteLine($"Факториал от {num} = {GetMultiply(num)}");



// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size]; // size = 2; result = [0,0]
//     for (int i = 0; i < result.Length; i++) // size = result.Length
//     {
//         result[i] = new Random().Next(2); // если указано одно число, то идем от 0 до этого числа
//     }
//     return result;
// }
// int[] testArray = GetBinaryArray(8);
// Console.WriteLine($"Массив: [ {String.Join("; ",testArray)} ]");


123