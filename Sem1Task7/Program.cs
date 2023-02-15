
System.Random numSintezator = new System.Random();

//Вариант 1
int rndNumber = numSintezator.Next(10,100);
console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if(firstNum>secondNum)
{
console.WriteLine(firstNum);
}
else
{
console.WriteLine(secondNum);    
}