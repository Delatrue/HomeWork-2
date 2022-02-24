using System;

namespace OOP7
{
    interface ICoder
    {
        void Encode(string textIn);
        void Decode(string textOut);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACoder testTextA = new ACoder();
            testTextA.Encode("OneCharUp");
            testTextA.Decode("PofDibsVq");

            BCoder testTextB = new BCoder();
            testTextB.Encode("CharMirror");
            testTextB.Decode("XsziNriili"); //WryhMqhhkh
        }        
    }
}
