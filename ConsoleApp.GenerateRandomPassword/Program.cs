using System;
using System.Linq;
using System.Text;

namespace ConsoleApp.GenerateRandomPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              65, 91: A-Z
              97, 123: a-z
              48, 58: 0-9
            */

            int[] charCodes = new int[0];
            int len;

            for (int i = 65; i < 91; i++)
            {
                len = charCodes.Length;
                Array.Resize(ref charCodes, len+1);
                charCodes[len] = i;
            }

            for (int i = 97; i < 123; i++)
            {
                len = charCodes.Length;
                Array.Resize(ref charCodes, len + 1);
                charCodes[len] = i;
            }

            for (int i = 48; i < 58; i++)
            {
                len = charCodes.Length;
                Array.Resize(ref charCodes, len + 1);
                charCodes[len] = i;
            }
            Console.WriteLine("#################");

            Random r = new Random();

            len = 8;
            int randomIndex;
            string s = "";

            for (int i = 0; i < len; i++)
            {
                randomIndex = r.Next(0, charCodes.Length);

                int eded = charCodes[randomIndex];
                char ch = Convert.ToChar(eded);

                s = s + ch.ToString();
            }

            Console.WriteLine(s);

            //Random r = new Random();

            //int len = 8;
            //int num;

            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < len; i++)
            //{
            //    num = r.Next(65, 91);
            //    char ch = Convert.ToChar(num);

            //    sb.Append(ch);
            //}

            //string word = sb.ToString();
            //Console.WriteLine(word);
        }
    }
}
