using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Conversor
    {
        public static string DecimalBinario(int n)
        {
            string resultado = "";
            string concatenacion;
            int num;
            while (n > 1) {
                num = n % 2;
                concatenacion = num.ToString();
                resultado+=concatenacion;
                n = n / 2;
                //Console.WriteLine("Resultado: " + resultado + " N: " + n);
                if(n == 1 || n == 0)
                {
                    concatenacion = n.ToString();
                    resultado += concatenacion;
                    resultado= Reverse(resultado);
                } 
            }
            return resultado;
        }

        public static int BinarioDecimal(string s)
        {
            int result = 0;
            int charInt;
            int acu;
            int potencia = 1;
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            for (int i = 0; i < s.Length; i++)
            {
                if (charArray[i] == '1')
                {
                    charInt = int.Parse(charArray[i].ToString());
                    acu = potencia * charInt;
                    //Console.WriteLine("!!!!! {0} / {1} / {2}", acu, potencia, charArray[i]);
                    result = result + acu;
                }
                potencia = potencia * 2;
            }
            //return int.Parse(new string());
            return result;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
