// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите число A: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int num_B = Convert.ToInt32(Console.ReadLine());
// Involution(num_A, num_B);

// // Функция для возведения A в степень B
// void Involution(int A, int B)
// {
//     int sum = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         sum = sum * A;
//     }
//     Console.WriteLine(sum);
// }

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// int len = LenNum(num_A);
// SumNum(num_A, len);

// int LenNum(int A)
// {
//     int i = 0;
//     while (A > 0)
//     {
//         A /= 10;
//         i++;
//     }
//     return i;
// }

// void SumNum(int num_A, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += num_A % 10;
//         num_A /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,9);
    Console.Write(array[i] + " ");
}

