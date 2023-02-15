// Задача №11
// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();

int rndNum = rnd.Next(100, 1000);
Console.WriteLine($"Рандомное число = {rndNum}");

int lastDigit = rndNum % 10;
int firstDigit = rndNum / 100;
rndNum = firstDigit * 10 + lastDigit;
Console.WriteLine($"Получившееся число = {rndNum}");
