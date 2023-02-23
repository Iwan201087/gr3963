//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Описание метод ReadData для чтения входных данных  от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Описание метод WriteAnswer для записи ответа для пользователя
void WriteAnswer(string answ)
{
    Console.WriteLine(answ);
}
int num = ReadData("Введите пятизначное число: "); // вызов метода ReadData ввода пятизначного числа
//Описание метода PalinTest для прохождения теста введенного числа на палиндром
bool PalinTest(int num)
{
bool res = false;
 if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10)) //сравнение первой и пятой цифры числа, а так же второй и четвертой цифры 
{
res = true;
}
return res;
}
bool res = PalinTest(num); // Вызов метода PalinTest
if (num < 10000 || num > 100000) WriteAnswer($"Вы ввели не пятизначное число!");// Проверка введеного числа на пятизначность
else
if  (res == true) WriteAnswer ("Введеное число - палиндром"); // Вывод сообщения, если число палиндром
else WriteAnswer($"Введеное число - не палиндром!"); // Вывод сообщения, если число не палиндром

