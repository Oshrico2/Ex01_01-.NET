
using System;
using System.Text;
namespace Ex01_02
{

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Ex01_02!");
            int totalRows = 9;
            StringBuilder sb = new StringBuilder();
            MakeDiamond(totalRows, 1, ref sb);
            Console.WriteLine(sb.ToString());
        }


        public static void MakeDiamond(int totalRows, int currentRow, ref StringBuilder i_Sb)
        {
            if (currentRow < (totalRows / 2) + 1)
            {
                BuildTopDiamond(totalRows, currentRow, ref i_Sb);
            }
            else if (currentRow >= (totalRows / 2) + 1 && currentRow < totalRows + 1)
            {
                BuildBottomDiamond(totalRows, currentRow, ref i_Sb);
            }
        }

        static void BuildTopDiamond(int totalRows, int currentRow, ref StringBuilder i_Sb)
        {
            AppendSpaces((totalRows / 2) + 1 - currentRow, ref i_Sb);
            AppendStars(2 * currentRow - 1, ref i_Sb);
            i_Sb.AppendLine();
            MakeDiamond(totalRows, currentRow + 1, ref i_Sb);
        }

        static void BuildBottomDiamond(int totalRows, int currentRow, ref StringBuilder i_Sb)
        {
            AppendSpaces(currentRow - (totalRows / 2 + 1), ref i_Sb);
            AppendStars(2 * (totalRows + 1 - currentRow) - 1, ref i_Sb);
            i_Sb.AppendLine();
            MakeDiamond(totalRows, currentRow + 1, ref i_Sb);
        }


        static void AppendSpaces(int count, ref StringBuilder i_Sb)
        {
            for (int i = 0; i < count; i++)
            {
                i_Sb.Append(" ");
            }
        }

        static void AppendStars(int count, ref StringBuilder i_Sb)
        {
            for (int i = 0; i < count; i++)
            {
                i_Sb.Append("*");
            }
        }
    }
}
