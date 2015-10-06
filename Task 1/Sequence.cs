using System;
using System.Collections.Generic;

namespace Sequence
{
    class Sequence
    {
        static String argument;
        static List<string> transformList;
        static bool flag;
        static void Main(string[] args)
        {
            if (args.Length > 1 || args.Length == 0)
            {
                Console.Write("-");
                return;
            }
            else if (args[0] == "1")
                return;
            else
            {
                argument = args[0];
                string temp = String.Empty;
                foreach (var symbol in argument)
                {
                    if (!Char.IsNumber(symbol))
                    {
                        Console.WriteLine("-");
                        return;
                    }
                    if (symbol.ToString() == "0")
                        temp += "0";
                    else
                        for (int i = 0; i < Convert.ToInt32(symbol.ToString()); i++)
                            temp += "1";
                }
                argument = temp;
                transformList = new List<string>();
                flag = false;
                int count = 0;
                while (flag != true)
                {
                    if (!CheckA() && !CheckB() && !CheckC() && !CheckD())
                        flag = true;
                    count++;
                    if (count > 10000)
                    {
                        Console.WriteLine("-");
                        Console.ReadKey();
                        return;
                    }
                }
                transformList.Reverse();
                foreach (var transformation in transformList)
                    Console.WriteLine(transformation);
                Console.ReadKey();
            }
        }

        static bool CheckA()
        {
            bool tempFlag = false;
            if (argument.Length > 1)
                if ((argument[argument.Length - 2]).ToString() + (argument[argument.Length - 1]).ToString() == "10")
                {
                    transformList.Add("A");
                    argument = argument.Substring(0, argument.Length - 1);
                    tempFlag = true;
                }
            return tempFlag;
        }
        static bool CheckB()
        {
            bool tempFlag = false;
            if (argument.Length % 2 == 0)
                if (argument.Substring(0, (argument.Length / 2)) == argument.Substring((argument.Length / 2), (argument.Length / 2)))
                {
                    transformList.Add("B");
                    argument = argument.Substring(0, argument.Length / 2);
                    tempFlag = true;
                }
            return tempFlag;
        }
        static bool CheckC()
        {
            bool tempFlag = false;
            for (int i = 0; i < argument.Length; i++)
                if (argument[i].ToString() == "0")
                {
                    argument = argument.Remove(i, 1);
                    argument = argument.Substring(0, i) + "111" + argument.Substring(i, argument.Length - i);
                    transformList.Add("C" + i);
                    return tempFlag = true;
                }
            return tempFlag;
        }
        static bool CheckD()
        {
            bool tempFlag = false;
            if (argument != "1")
            {
                transformList.Add("D" + (argument.Length));
                argument += "00";
                tempFlag = true;
            }
            return tempFlag;
        }
    }
}
