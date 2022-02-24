using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    internal class BCoder : ICoder
    {
        //Шифрование строки
        public void Encode(string textIn)
        {
            //Создаем динамическую строку
            StringBuilder stringBuilder = new StringBuilder(textIn.Length);
            foreach(char c in textIn)
            {
                char charRotate = c switch // содаем поле, куда будем записывать изменяемую строку 
                {
                    >= 'A' and <= 'Z' => (char)('A' + 'Z' - c), //CharMirror 'C' = 41 + 5A - 43 = 'X'
                    >= 'a' and <= 'z' => (char)('a' + 'z' - c),
                    >= 'А' and <= 'Я' => (char)('А' + 'Я' - c),
                    >= 'а' and <= 'я' => (char)('а' + 'я' - c),
                    _ => c

                };
                stringBuilder.Append(charRotate);
                stringBuilder.ToString();
            }
            Console.WriteLine(stringBuilder);
        }
        public void Decode(string textOut)
        {
            StringBuilder stringBuilder2 = new StringBuilder(textOut.Length);
            foreach (char c in textOut)
            {
                char charRotate2 = c switch // содаем поле, куда будем записывать изменяемую строку 
                {
                    >= 'A' and <= 'Z' => (char)('A' + 'Z' - c), //CharMirror 'C' = 41 + 5A - 43 = 'X'
                    >= 'a' and <= 'z' => (char)('a' + 'z' - c),
                    >= 'А' and <= 'Я' => (char)('А' + 'Я' - c),
                    >= 'а' and <= 'я' => (char)('а' + 'я' - c),
                    _ => c

                };
                stringBuilder2.Append(charRotate2);
                stringBuilder2.ToString();
            }
            Console.WriteLine(stringBuilder2);
        }
    }
}
