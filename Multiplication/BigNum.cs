using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeNumber
{
    class BigInt
    {
        private List<int> Whole = new List<int>();
        private char Sign;

        public static implicit operator BigInt(string number)
        {
            BigInt Designer = new BigInt();
            Designer.Conversion(number);
            return Designer;
        }
        

        public void Print()
        {
            Console.Write(Sign);
            for (int i = Whole.Count-1; i >= 0; i--)
            {
                Console.Write($"{Whole[i]}");
            }
        } 

        public static BigInt operator *(BigInt mult, BigInt fact)
        {
            BigInt compositions = new BigInt();
            if ((mult.Sign == '-' && fact.Sign != '-') || (fact.Sign == '-' && mult.Sign != '-'))
                compositions.Sign = '-';

            for (int i = 0; i < fact.Whole.Count; i++)
            {
                for (int j = 0; j < mult.Whole.Count; j++)
                {
                    if (i + j >= compositions.Whole.Count)
                    {
                        compositions.Whole.Add(mult.Whole[j] * fact.Whole[i]);
                    }
                    else
                    {
                        compositions.Whole[i + j] += mult.Whole[j] * fact.Whole[i];
                    }
                }
            }
            compositions.DivideCategory();
            return compositions;
        }

        private void DivideCategory()
        {
            for(int i = 0; i < Whole.Count; i++)
            {
                if (Whole[i] > 9)
                {
                    if (i + 1 >= Whole.Count)
                    {
                        Whole.Add(Whole[i] / 10);
                    }
                    else
                    {
                       Whole[i + 1] += Whole[i] / 10;
                    }
                    Whole[i] = Whole[i] % 10;
                }
            }
        }

        private void Conversion(string number)
        {
            for(int i = number.Length-1; i >= 0; i--)
            {
                if (number[i] == '-')
                {
                    Sign = number[i];
                }
                else
                {
                    Whole.Add(int.Parse(Convert.ToString(number[i]))); //плохо временно
                }
            }
        }


    }
}
