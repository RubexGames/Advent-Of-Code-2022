using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //static char first;
        //static char second;
        //static char thirth;
        //static char fourth;
        //static char fifth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        //static char fourth;
        static List<char> list = new List<char>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for(int i = 0; i < 14; i++)
            {
                list.Add(input[i]);
            }

            if (Dups())
                Console.WriteLine(14);
            else
            {
                for (int i = 14; i < input.Length; i++)
                {

                    list.RemoveAt(0);
                    list.Add(input[i]);
                    if (Dups())
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }
            }
            
                              
        }                     
        static bool Dups()    
        {

            List<char> list2 = new List<char>();
            foreach(char c in list)
                list2.Add(c);

            list2.Sort();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list2[i] == list2[i + 1])
                    return false;
            }
            return true;

            //for (int i = 0; i < copy.Count; i++)
            //{
            //    char test = copy.RemoveAt(i);

            //}
            //if (first == second || first == thirth || first == fourth || second == thirth || second == fourth || thirth == fourth)
            //    return false;
            //return true;
        }
    }
}