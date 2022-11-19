// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string msg)
{
    Console.Write(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] CreateArray(int length)
{
    if (length < 2)
    {
        length = 2;
    }
    
    int[] tempArray = new int[length];
    tempArray[0]=0;
    tempArray[1]=1;
    
    for (int i = 2; i < length; i++)
    {
        tempArray[i] = tempArray[i-1] + tempArray[i-2];
    }
    return tempArray;
}

int digit = Prompt("Enter number: ");
int[] Fibonacci = CreateArray(digit);
PrintArray(Fibonacci);


