﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {

        public static int SommaInteri(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double SommaDecimali(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int DifferenzaInteri(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double DifferenzaDecimali(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int ProdottoInteri(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double ProdottoDecimali(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int ValAssolutoInt(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num >= 1)
            {
                return num;
            }
            else
            {
                return num * -1;
            }

        }

        public static double ValAssolutoDecimale(double num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num >= 1)
            {
                return num;
            }
            else
            {
                return num * -1;
            }
        }

        public static int MinInt(int num1, int num2)
        {
            switch (num1 - num2)
            {
                case 0:
                    return num1;
                    break;
                case < 0:
                    return num1;
                    break;
                default:
                    return num2;
                    break;
            }
            
        }

        public static double MinDec(double num1, double num2)
        {
            switch (num1 - num2)
            {
                case 0:
                    return num1;
                    break;
                case < 0:
                    return num1;
                    break;
                default:
                    return num2;
                    break;
            }

        }

        public static int MaxInt(int num1, int num2)
        {
            switch (num1 - num2)
            {
                case 0:
                    return num1;
                    break;
                case < 0:
                    return num2;
                    break;
                default:
                    return num1;
                    break;
            }
        }

        public static double MaxDec(double num1, double num2)
        {
            switch (num1 - num2)
            {
                case 0:
                    return num1;
                    break;
                case < 0:
                    return num2;
                    break;
                default:
                    return num1;
                    break;
            }

        }

        public static float PotenzaInt(float numBase, int esponente)
        {

            if (esponente == 0 && numBase == 0)
            {
                return 1;
            }

            if (esponente >= 0)
            {
                float esponenziale = numBase;

                for (int i = 1; i < esponente; i++)
                {
                    esponenziale = esponenziale * numBase;
                }
                return esponenziale;
            }
            else if (esponente < 0) 
            {
                int absEsponente = ValAssolutoInt(esponente);
                return 1 /(numBase * PotenzaInt(numBase, absEsponente));
            }
            return 0;


        }
    }
}
