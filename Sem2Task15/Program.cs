// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
//Преобразование в int и проверка на ненулевое значение через Parse
int numDay = int.Parse(Console.ReadLine()??"0");
if (numDay>0&&numDay<6)
    { 
        Console.WriteLine ($"Введенный день недели {numDay} - рабочий"); // вывод 
    }
else
{
    Console.WriteLine ($"Введенный день недели {numDay} - выходной"); // вывод
}
