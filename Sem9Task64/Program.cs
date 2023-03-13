//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
//Принимаем из консоли число
//Метод для получения данных от пользователя
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод для вывода в консоль сообщения
void PrintData(string mess)
{
    Console.WriteLine(mess);
}
//Рекурсивный метод для вывода в виде строки всех натуральных чисел в промежутке от 1 до N
string WriteStringRec(int N, int num)
{
    string res = String.Empty;// инициализируем пустую строку
    if (num <= N) // точка остановки рекурсии num <= N
    {
        res += num + " " + WriteStringRec(N, num + 1);// изменение при вызове функции
        return res;
    }
    else
    {

        return res;
    }
}


int num = ReadData("Введите до которого выводить  последовательность: ");
PrintData($"{WriteStringRec(num, 1)}");