using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            //define string
            string str = "exemplo";

            //converte string em array de caracteres
            char[] chars = str.ToCharArray();

            //inverte caracteres
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            //nova string de caracteres invertidos
            string reversedStr = new string(chars);

            //exibe string invertida
            Console.WriteLine(reversedStr);
        }
    }
}
