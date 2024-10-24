using System;
using System.Threading.Channels;

namespace Lab4_Butok
{
    class Domino
    {
        public int First { get; private set; }//перша сторона доміно
        public int Second { get; private set; }//друга сторона доміно

        public Domino(int first, int second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()//виведення доміно
        {
            return  $"║{First}║{Second}║";
            
        }
    }
}
