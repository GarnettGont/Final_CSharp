// Функция Аккермана

int AckermannFun(int m, int n)
{

    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckermannFun(1, n - 1);
    }
    else
    {
        return AckermannFun(AckermannFun(m - 1, n), n - 1);
    }

}

Console.Write("Write first not negative number: ");
int numM = Convert.ToInt32(Console.ReadLine()); ;
Console.Write("Write second not negative number: ");
int numN = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine(AckermannFun(numM, numN));