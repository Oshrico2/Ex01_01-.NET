
using DiamondProgram = Ex01_02.Program;
using System.Text;
using System;

class Program
{

    static void Main()
    {
        System.Console.WriteLine("Enter number of rows for the diamond:");
        int.TryParse(System.Console.ReadLine(), out int numOfRows);
        StringBuilder sb;
        MakeDinamicDiamond(ref numOfRows, out sb);
        System.Console.WriteLine(String.Format("Diamond with {0} rows:", numOfRows));
        System.Console.WriteLine(sb.ToString());



    }

    static void MakeDinamicDiamond(ref int i_NumOfRows, out StringBuilder sb)
    {
        sb = new StringBuilder();
        if (i_NumOfRows % 2 == 0)
        {
            ChooseAddOrDropRow(ref i_NumOfRows);
        }

        DiamondProgram.MakeDiamond(i_NumOfRows, 1, ref sb);

    }

    static void ChooseAddOrDropRow(ref int i_NumOfRows)
    {
        System.Console.WriteLine("You selected an even number, a symmetrical diamond cannot be displayed\nSelect 1 to add a row or 0 to drop a row");

        char chosenNumber;
        do
        {
            char.TryParse(Console.ReadLine(), out chosenNumber);
            if (chosenNumber != '0' && chosenNumber != '1')
            {
                Console.WriteLine("Please select 1 to add a row or 0 to drop a row");
            }

        } while (chosenNumber != '0' && chosenNumber != '1');

        i_NumOfRows += (chosenNumber == '1') ? 1 : -1;
    }


}