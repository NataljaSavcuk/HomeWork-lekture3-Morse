namespace HomeWork_lekture3_Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj! Jmenuji se ROB v1.1 a umím základy Morseovy abecedy!\n" +
                "Umím pouze základy, tak že prosím mluv na mě pomalu,\n" +
                "pouze latinská písmena (bez diakritiky) a čísla.\n Jdeme na to a vyzkoušíme moje schopnosti!");
            //Potřebuji nápovědu - jak vůbec najdu v ASCII kód pro znaky s diakritikou? A v jakém oni tam jsou pořadí?

            Console.WriteLine("Zadej text:");
            string text = Console.ReadLine().ToUpper(); 
            char[] pismena = text.ToCharArray();

            Console.WriteLine("V Morsovce to bude vzpadát přibližně tak: "); // Přibližně - protože CH lze napsat jako jeden znak ale i
                                                                             // jako 2 znaky, a budou se lišít. A nevím jak mám
                                                                             // (i jestli musím) převest do morseovky speciální znaky
            Console.WriteLine();
            for (int i = 0; i < pismena.Length; i++)
            {
                Console.Write(Class1.Morse(pismena[i])); //musíme znaky morseovky něják rozdělovat? Mezerou, čárkou?
            }
            Console.ReadLine();
        }
    }
}