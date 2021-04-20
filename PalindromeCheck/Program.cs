using System;

class MainClass
{

    public static string StringChallenge(string firstStr)
    {

        char[] palindromeArray = firstStr.ToCharArray();
        Array.Reverse(palindromeArray);
        string second = new string(palindromeArray);

        return second;
    }

    static void Main()
    {
        string firstStr = Convert.ToString(Console.ReadLine());
        firstStr = firstStr.Replace(" ", "");
        string secondStr = StringChallenge(firstStr);


        if (firstStr.Equals(secondStr))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        Console.ReadLine();
    }


}