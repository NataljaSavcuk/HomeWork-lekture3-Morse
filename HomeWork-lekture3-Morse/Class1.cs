using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lekture3_Morse
{
    public static class Class1
    {
        public static string Morse(char znak) 
        {
            string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] morseovyCisla = { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."};
            string temp = "";


            if ((znak >= '0') && (znak <= 'Z')) //Toto jsem ne vymyslela já, ani jsem nevěděla že tak to jde.
                                                //Chtěla jsem napsat normalní array a abecedou a táhat s něj znaky v cyklu for.
                                                //Manžel řekl že programátor musí byt líný a ukázal tuto cestu. :)
            {
                temp = morseovyZnaky[ znak - 'A'];
            }
            else
            {
                if ((znak >= '0') && (znak <= '9'))
                {
                    temp = morseovyCisla[znak - '0'];
                }
                else
                {
                    temp = znak.ToString();
                }
            }
            return temp;
        }
    }
}
