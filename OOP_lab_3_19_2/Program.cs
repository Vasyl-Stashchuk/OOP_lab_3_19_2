using System;
using System.IO;

namespace OOP_lab_3_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.txt");

            string str = file.ReadToEnd();

            string[] sentences = str.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            str = "";

            for (int i = 0; i < sentences.Length; ++i)
            {
                str += sentences[i] + " ";
            }

            sentences = str.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Кiлькiсть речень: {0}", sentences.Length);
        }
    }
}
