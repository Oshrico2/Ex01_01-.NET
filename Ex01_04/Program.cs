

using System;

public class Program
{
    public static void Main()
    {
        StartProgram();

    }

    static void StartProgram()
    {
        string s = GetInput();
        StringOrNumbers(s);
    }
    static string GetInput()
    {
        string input;

        do
        {
            Console.WriteLine("Please enter an 8-character input consisting only of numbers or letters in English only and press enter:");
            input = Console.ReadLine();
        } while (input.Length != 8);

        return input;
    }

    static void StringOrNumbers(string i_Str)
    {
        if (IsAlphabetic(i_Str))
        {
            System.Console.WriteLine(String.Format("You chose an alphabetic string: {0}", i_Str));
            AlphabeticMethods(i_Str);
        }
        else if (IsNumeric(i_Str, out int number))
        {
            System.Console.WriteLine(String.Format("You chose a numeric string: {0}", number));

            NumericMethods(number);
        }
        else
        {
            StartProgram();


        }
    }

    static bool IsAlphabetic(string i_Str)
    {
        bool isAlphabetic = true;

        foreach (char c in i_Str)
        {
            if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))) //Check according to the ASCII value to receive only English letters
            {
                isAlphabetic = false;
                break;
            }
        }

        return isAlphabetic;
    }

    static bool IsNumeric(string i_Str, out int o_Number)
    {
        return int.TryParse(i_Str, out o_Number);
    }

    static void AlphabeticMethods(string i_Str)
    {
        LowerUpperCase(i_Str);
        IsPalindrome(i_Str, 0, i_Str.Length - 1);

    }

    static void NumericMethods(int i_Number)
    {
        DivideByFive(i_Number);
    }

    static void LowerUpperCase(string i_Str)
    {
        int lower = 0, upper = 0;
        foreach (char letter in i_Str)
        {
            if (char.IsLower(letter))
            {
                lower++;
            }
            else
            {
                upper++;
            }
        }
        System.Console.WriteLine(String.Format("Sum of letters : 8\n{0} is lower letters and {1} is upper letters", lower, upper));
    }

    static void IsPalindrome(string i_Str, int i, int j)
    {
        if (i < j && i_Str[i] != i_Str[j])
        {
            Console.WriteLine("The string is not a palindrome.");
            return;
        }

        if (i < j)
        {
            IsPalindrome(i_Str, i + 1, j - 1);
        }
        else
        {
            Console.WriteLine("The string is a palindrome.");
        }
    }

    static void DivideByFive(int i_Num)
    {
        string message = i_Num % 5 == 0
            ? String.Format("The number {0} is divisible by 5 without a remainder.", i_Num)
            : String.Format("The number {0} is not divisible by 5 without a remainder.", i_Num);

        System.Console.WriteLine(message);
        return;
    }

}