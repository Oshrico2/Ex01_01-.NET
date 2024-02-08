using System;


class Program
{
    static void Main()
    {
        string inputNum;
        Console.WriteLine("please enter a 9 digits positive integer number - ");
        do
        {
            inputNum = Console.ReadLine();

        }
        while (!CheckNum(inputNum));
        MinMaxDigit(inputNum);
        DigitDiviedInFour(inputNum);
        NumOfDigitsBiggerThenUnity(inputNum);
    }



    static bool CheckNum(string i_num)
    {
        if (i_num.Length != 9 || !int.TryParse(i_num, out _))
        {
            Console.WriteLine("incorrect, please try again");
            return false;

        }
        return true;
    }

    static void MinMaxDigit(string i_num)
    {
        char maxDigit = i_num[0];
        char minDigit = i_num[0];

        for (int i = 0; i < 9; i++)
        {
            if (i_num[i] > maxDigit)
            {
                maxDigit = i_num[i];
            }

            if (i_num[i] < minDigit)
            {
                minDigit = i_num[i];
            }
        }
        Console.WriteLine($"The max digit is {maxDigit} and the min digit is {minDigit}");
    }
    static void DigitDiviedInFour(string i_num)
    {
        int count = 0;
        for (int i = 0; i < 9; i++)
        {
            if (i_num[i] == '0' || i_num[i] == '4' || i_num[i] == '8')
            {
                count++;
            }
        }
        Console.WriteLine($"the number of digits devieded in 4 is {count}");
    }



    static void NumOfDigitsBiggerThenUnity(string i_num)
    {
        char unity = i_num[8];
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (i_num[i] > unity)
            {
                count++;
            }
        }
        Console.WriteLine($"The number of digits that are bigger then the unity digit is {count}");
    }

}