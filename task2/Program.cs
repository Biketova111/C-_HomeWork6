/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */



using System.Reflection.Metadata;

const int cofficient = 0;
const int constanta = 1;
const int lineOne = 1;
const int lineTwo = 2;
const int coordsX = 0;
const int coordsY = 1;



double GetNamber(string message)
{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, Вы ввели не число. Повторите ввод.");
        }
    }
    return result;
}

double[] GetInputDataLine(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[cofficient] = GetNamber($"Введите коэфициент для {numberOfLine} прямой: ");
    lineData[constanta] = GetNamber($"Введите константу для {numberOfLine} прямой: ");
    
   
    return lineData;
}

bool ValidateLine(double[] lineDataOne, double[] lineDataTwo)
{
    if (lineDataOne[cofficient] == lineDataTwo[cofficient])
    {
        if (lineDataOne[constanta] == lineDataTwo[constanta])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] FindeCoords(double[] lineDataOne, double[] lineDataTwo)
{
    double[] coord = new double[2];
    coord[coordsX] = (lineDataOne[constanta] - lineDataTwo[constanta]) /
    (lineDataTwo[cofficient] - lineDataOne[cofficient]);
    coord[coordsX] = lineDataOne[constanta] * coord[coordsX] +
    lineDataOne[cofficient];
    return coord;
}

double[] line1 = GetInputDataLine(lineOne);
double[] line2 = GetInputDataLine(lineTwo);

if (ValidateLine(line1, line2))
{
    double[] cords = FindeCoords(line1, line2);
    Console.Write($"Точка пересечения прямых, заданных уравнениями ");
    Console.Write($"y= {line1[cofficient]} *x + {line1[constanta]} и ");
    Console.Write($" y= {line2[cofficient]} *x + {line2[constanta]} ");
    Console.WriteLine($"имеет координаты {cords[coordsX]}, {cords[coordsY]}");

}


