// Программа, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int PromptInt(string msg)
{
    Console.Write(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

void Printarray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}: ");
    }
    Console.WriteLine();
}

int[] GetBinary(int decNum)
{
    int[] binaryNum = new int[10];
    int i = binaryNum.Length - 1;
    while (decNum > 0)
    {
        binaryNum[i] = decNum % 2;
        decNum /= 2;
        i--;
    }
    return binaryNum;
}

int decNum = PromptInt("Enter decimal number: ");

Printarray(GetBinary(decNum));


