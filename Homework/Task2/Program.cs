// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

string Findintersection (int intB1, int intK1, int intB2, int intK2)
{
    if (intB1==intB2 && intK1==intK2) return "Lines coincide, an infinite number of common points.";
    if (intK1==intK2) return "Lines are parallel, no points of intersection.";
    double dblX =  Math.Round((double)(intB2 - intB1) / (double)(intK1 - intK2),2);
    double dblY = Math.Round(intK1 * dblX + intB1,2);
    return $"The lines intersect at a point({dblX}, {dblY}).";
}

int intB1 = PromptInt("Enter b1: ");
int intK1 = PromptInt("Enter k1: ");
int intB2 = PromptInt("Enter b2: ");
int intK2 = PromptInt("Enter k2: ");
Console.Write(Findintersection (intB1: intB1, intK1, intB2, intK2));

