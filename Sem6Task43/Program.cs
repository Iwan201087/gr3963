int coefficient = 0;
int constant = 1;
int xCoord = 0;
int yCoord = 1;
int line1 = 1;
int line2 = 2;
// Метод для ввода данных от пользователя в вещественном формате
double ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}
//Метод для ввода параметров уравнения прямых
double  InputLineData (int numberLine)
{
    double [] lineData = new double [2];
    lineData[coefficient] = ReadData($"Введите коэффициент для х {numberLine} прямой  ");
    lineData[constant] = ReadData($"Введите константу в для  {numberLine} прямой  ");
    return lineData;
}
//Метод для нахождения координат пересечения точки пересечения прямых
double  FindCrossPointCoords(double [] lineData1, double [] lineData2)
{
    double [] coord = new double [2];
    coord[xCoord] = ((lineData1[constant]-lineData2[constant]))/((lineData1[coefficient]-lineData1[coefficient]));
    coord[yCoord] = lineData1[constant]*coord[xCoord]+lineData1[constant];
    return coord;
}
//Метод вывода координат точки пересечения прямых
double [] ValidateLine( double lineData1, double lineData2)
{
    coord = FindCrossPointCoords (lineData1, lineData2);
    Console.Write ($"Точка пересечения уравнений у= {lineData1[coefficient]}*X+ {lineData1[constant]} и у= {lineData2[coefficient]}*X+ {lineData2[constant]} имеет координаты ({coord[xCoord]},({coord[yCoord]}");
}
double   lineData1=InputLineData(line1);
double  lineData2=InputLineData(line2);
ValidateLine (xcoord, yCoord);
