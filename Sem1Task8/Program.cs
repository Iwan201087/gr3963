﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//ввод числа 
Console.Write("Введите число N: ");
//Преобразование N в int и проверка на ненулевое значение
int numN = Convert.ToInt32(Console.ReadLine());
// цикл вывода четных чисел от 1 до N (включительно), при этом i изменяется от 2 (что бы сразу перебирать
// только четные значения), условие выхода из цикла i<=N, итератор i c каждым шагом цикла изменяется на значение i+2) 
for (int i=2; i<=numN; i=i+2)
{
    Console.Write(i+"  ");  
}
