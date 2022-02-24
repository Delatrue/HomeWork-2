using System;
using System.IO;

namespace OOP3._3
{
    internal class Program
    {
        public void SearchMail(ref string s)
        {
            string path = @"C:\ExampleDir\NameEmail.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    s = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
                        
        }
    }
}
