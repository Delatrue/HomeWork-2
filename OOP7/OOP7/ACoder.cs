using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    public class ACoder : ICoder 
    {
        //Величина сдвига
        private int shiftNum = 1;
        //Шифрование строки
        public void Encode(string textIn)
        {
            string tempString = default; // содаем поле, куда будем записывать изменяемую строку
            for(int i = 0; i < textIn.Length; i++)
            {
                tempString += (char)(textIn[i] + shiftNum);
                //tempString.ToString();
            }
            Console.WriteLine(tempString);
        }
        //Дешифрование по аналогии с шифрованием
        public void Decode(string textOut)
        {
            string tempString = default;
            for (int i = 0; i < textOut.Length; i++)
            {
                tempString += (char)(textOut[i] - shiftNum); // меняем сдвиг в обратную сторону
                tempString.ToString();
            }
            Console.WriteLine(tempString);
        }
    }
}
