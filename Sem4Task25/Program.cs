//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int ReadInputInt(string mess)// Метод для воода данных от пользователя
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void WriteMess(string mess) // Метод для вывода сообщения от программы
{
    Console.WriteLine(mess);
}
int Exponentiation(int expBase, int exp) //Метод для возведения в степень
{   
    int res = 1;
    for(int i = 0; i< exp; i++)
    {
        res *= expBase;
    }
    return res;
}

int expBase = ReadInputInt("Введите основание для возведения в степень: ");
int exp = ReadInputInt("Введите показатель степени: ");
WriteMess($"Число {expBase} в степени {exp} равно {Exponentiation(expBase,exp)}");