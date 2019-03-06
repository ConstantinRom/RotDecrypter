using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotDecrypter
{
    class Crypter
    {
       public static string Encrypt(string toEncrypt, string shiftstr)
        {

            const int alphabetLength = 'z' - 'a' + 1;
            char[] buffer = toEncrypt.ToCharArray();


            if (shiftstr.ToString().Equals("inverse"))
            {
                Array.Reverse(buffer);
                return new string(buffer);
            }




            for (int i = 0; i < buffer.Length; i++)
            {

                if (!Char.IsNumber(buffer[i]) && !buffer[i].Equals('\n') && !buffer[i].Equals(' '))
                {
                    int shift = Convert.ToInt32(shiftstr);

                    if (Char.IsUpper(buffer[i]))
                    {
                        char letter = (char)(buffer[i] - 'A');
                        letter = (char)((letter + shift) % alphabetLength);
                        buffer[i] = (char)(letter + 'A');
                    }

                    else
                    {
                        char letter = (char)(buffer[i] - 'a');
                        letter = (char)((letter + shift) % alphabetLength);
                        buffer[i] = (char)(letter + 'a');
                    }



                }


            }
            return new string(buffer);
        }
    }
}
