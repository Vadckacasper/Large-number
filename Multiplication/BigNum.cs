using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeNumber
{
    class BigInt
    {
        private byte[] Whole;
        private int SizeWhole;

        public static implicit operator BigInt(string number)
        {
            BigInt Designer = new BigInt();
            Designer.Conversion(number);
            return Designer;
        }

        private void Conversion(string number)
        {
            Whole = new byte[number.Length];
            foreach (char point in number)
            {
                Whole[SizeWhole] += byte.Parse(Convert.ToString(point)); //плохо временно
                SizeWhole++;
            }
        }

        public void Print()
        {
            for (int i = 0; i < SizeWhole; i++)
            {
                Console.Write(Whole[i]);
            }
        }
    }
}
