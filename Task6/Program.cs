//от 1....5

int Prompt(string msg)
{
    Console.Write(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

void Seq(int n)
{
    if (n <= 0)
    {
        return;
    }
    Seq(n - 1);
    Console.Write($" {n} ");
}
Seq(5);
