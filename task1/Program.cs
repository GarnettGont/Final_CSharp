// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void PrintResult(int startNum, int endNum)
{
    if (startNum > 0 && endNum > 0)
    {
        if (startNum < endNum)
        {
            Console.Write(startNum + ", ");
            PrintResult(startNum + 1, endNum);
        }
        else if (startNum > endNum)
        {
            Console.Write(startNum + ", ");
            PrintResult(startNum - 1, endNum);
        }
        else
        {
            Console.WriteLine(endNum);
            return;
        }
    }
    else
    {
        Console.WriteLine("Wrong input!");
    }
}

Console.Write("Write first natural number: ");
int numM = Convert.ToInt32(Console.ReadLine());;
Console.Write("Write last natural number: ");
int numN = Convert.ToInt32(Console.ReadLine());;

PrintResult(numM, numN);