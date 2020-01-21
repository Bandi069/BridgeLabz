using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutations
    {
        public void getPermute()
        {
            Console.WriteLine("Enter String for Permuations");
            String Str = Utility.InputString();
            int n=Str.Length;
            Permute(Str,n,n);
        }
        public  void Permute(String Str,int l,int r)
        {

             if (l == r)
            {
                Console.WriteLine(Str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Str = swap(Str, l, i);
                   Permute( Str,l + 1, r);
                    Str = swap(Str, l, i);
                }
            }
        }

       
        private static string swap(string S, int i, int j)
        {
            char temp;
            char[] charArray = S.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            string Str1 = new string(charArray);
            return Str1;
        }
    }
}
