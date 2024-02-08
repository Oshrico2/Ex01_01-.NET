
using System;


class Program
{



    static void Main()
    {
        Console.WriteLine("Welcome to Ex01_01\nPlease enter 3 binary positive numbers with 9 digits each one");
        string firstInput = UserInput();
        string secondInput = UserInput();
        string thirdInput = UserInput();

        int firstInputDecimal = BinaryToDecimal(firstInput);
        int secondInputDecimal = BinaryToDecimal(secondInput);
        int thirdInputDecimal = BinaryToDecimal(thirdInput);


        SortAndPrint(firstInputDecimal, secondInputDecimal, thirdInputDecimal);
        AvgOfOneAndZero(firstInput, secondInput, thirdInput);
        CheckPowOfTwo(firstInputDecimal, secondInputDecimal, thirdInputDecimal);
        NumberOfAscendingSeries(firstInputDecimal, secondInputDecimal, thirdInputDecimal);

    }

    static string UserInput()
    {
        string numberStr;

        do
        {

            numberStr = System.Console.ReadLine();

        } while (!IsValid(numberStr));

        return numberStr;
    }


    static bool IsValid(string i_Num)
    {
        if (i_Num.Length == 9)
        {
            bool isValid = true;

            foreach (char c in i_Num)
            {
                if (c != '0' && c != '1')
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return true;
            }
        }

        Console.WriteLine("Wrong input, enter another number");
        return false;


    }

    static int BinaryToDecimal(string i_BinaryNumber)
    {
        int decimalNumber = 0;
        int power = 0;
        for (int i = i_BinaryNumber.Length - 1; i >= 0; i--)
        {
            int digit = i_BinaryNumber[i] - '0';
            decimalNumber += digit * (int)Math.Pow(2, power);
            power++;
        }

        return decimalNumber;

    }

    static void SortAndPrint(int i_Num1, int i_Num2, int i_Num3)
    {
        int smallest, middle, largest;

        smallest = (i_Num1 < i_Num2) ? ((i_Num1 < i_Num3) ? i_Num1 : i_Num3) : ((i_Num2 < i_Num3) ? i_Num2 : i_Num3);

        largest = (i_Num1 > i_Num2) ? ((i_Num1 > i_Num3) ? i_Num1 : i_Num3) : ((i_Num2 > i_Num3) ? i_Num2 : i_Num3);

        middle = (i_Num1 + i_Num2 + i_Num3) - smallest - largest;

        Console.WriteLine(string.Format("Sorted Numbers: {0}, {1}, {2}", smallest, middle, largest));
        Console.WriteLine(string.Format("Min number : {0}\nMax number : {1}", smallest, largest));

    }

    static void AvgOfOneAndZero(string i_Str1, string i_Str2, string i_Str3)
    {
        int sumOfOnes = 0, sumOfZeros;


        for (int i = 0; i < i_Str1.Length; i++)
        {
            sumOfOnes += (i_Str1[i] == '1' ? 1 : 0);
            sumOfOnes += (i_Str2[i] == '1' ? 1 : 0);
            sumOfOnes += (i_Str3[i] == '1' ? 1 : 0);
        }
        sumOfZeros = (i_Str1.Length * 3) - sumOfOnes;


        Console.WriteLine(string.Format("Average of zeros is : {0}\nAverage of ones is : {1}", sumOfZeros / 3f, sumOfOnes / 3f));
    }

    static void CheckPowOfTwo(int i_Num1, int i_Num2, int i_Num3)
    {
        int counter = 0;
        counter += (i_Num1 & (i_Num1 - 1)) == 0 ? 1 : 0;
        counter += (i_Num2 & (i_Num2 - 1)) == 0 ? 1 : 0;
        counter += (i_Num3 & (i_Num3 - 1)) == 0 ? 1 : 0;

        Console.WriteLine(string.Format("The amount of numbers that are a power of 2 is : {0}", counter));
    }

    static void NumberOfAscendingSeries(int i_Num1, int i_Num2, int i_Num3)
    {
        int counter = 0;
        counter = IsAscendingSeries(i_Num1) + IsAscendingSeries(i_Num2) + IsAscendingSeries(i_Num3);

        Console.WriteLine(string.Format("Number of ascending series is : {0}", counter));
    }


    static int IsAscendingSeries(int i_Num1)
    {
        return i_Num1 / 10 == 0 ? 1 : (i_Num1 % 10 > (i_Num1 / 10) % 10 ? IsAscendingSeries(i_Num1 / 10) : 0);
    }


}