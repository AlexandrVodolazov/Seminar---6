// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

int[] PromptNumbers(int intN)
{
    int[] tempArray = new int[intN];
    for (int i = 0; i<intN; i++)
    {
        Console.Write($"Enter {i+1}-ое number: ");
        tempArray[i] = int.Parse(Console.ReadLine());
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

void PrintCountOfPositive(int[] intArray)
{
    int counter = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0) counter++;
    }
    Console.Write("Among the numbers ");
    printArray(intArray);
    Console.Write($" - {counter} more numbers 0");
}

int intN = PromptInt("How many integers are you willing to enter: ");
int[] arrNumbers = PromptNumbers(intN);
PrintCountOfPositive(arrNumbers);
