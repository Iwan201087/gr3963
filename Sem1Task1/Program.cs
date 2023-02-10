//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//ввод числа №1
Console.Write("Введите число №1: "); string numLine1 = Console.ReadLine();
//ввод числа №2
Console.Write("Введите число №2: ");
string numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
    //Convert to int
int num1 = int.Parse(numLine1);
int num2 = int.Parse(numLine2); 
if (num2 * num2 == num1) 
{ 
   Console.WriteLine("Да, является!"); 
} 
    else 
    { 
        Console.WriteLine("Нет, не является!"); 
    }


