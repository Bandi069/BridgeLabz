using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public static void CheckAnagram()
        {
            bool Statement= true;
            Console.WriteLine("Enter First String");
            String Str1 = Utility.InputString();
            Console.WriteLine("Enter Second String");
            String Str2 = Utility.InputString();
            int S1 = Str1.Length;
            int S2 = Str2.Length;
            if(S1!=S2)
            {
                Statement = false;
            }
            else
            {
                Char[] C1 = Str1.ToCharArray();
                Char[] C2 = Str2.ToCharArray();
                for(int i=0;i<S1;i++)
                {
                    for(int j=0;j<S2;j++)
                    {
                        if(C1[i]==C2[j])
                        {
                            Statement = true;
                        }
                    }
                }
                
            }  
            if (Statement == true)
            {
                Console.WriteLine("Given String is Anagram");
            }
            else
            {
                Console.WriteLine("Given String is Not Angram");
            }
        }
    }
}
