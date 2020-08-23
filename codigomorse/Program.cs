using System;
using System.Text;
using System.Media;

namespace codigomorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insertar texto al convertir: ");
            string mensaje;
            mensaje = Console.ReadLine();
            Console.WriteLine(Morsecode(mensaje));
        }

        static string Morsecode(string code)
        {
            string codex = code.ToUpper().Replace("A", ".-").Replace("B", " -... ").Replace("C", "-.-.").Replace("D", " -.. ").Replace("E", " . ").Replace("F", " ..-. ").Replace("G", " --. ").Replace("H", " .... ").Replace("I", " .. ").Replace("J", " .--- ").Replace("K", " -.- ").Replace("L", " .-.. ").Replace("M", " -- ").Replace("N", " -. ").Replace("O", " --- ").Replace("P", " .--. ").Replace("Q", " --.- ").Replace("R", " .-. ").Replace("S", " ... ").Replace("T", " - ").Replace("U", " ..- ").Replace("V", " •••- ").Replace("W", " .-- ").Replace("X", " -..- ").Replace("Y", " -.-- ").Replace("Z", " --.. ");

            foreach (char item in codex)
            {
                if (item.ToString().Contains("."))
                {
                    Console.Beep(800, 200);
                }

                else if (item.ToString().Contains("-"))
                {
                    Console.Beep(800, 200 * 3);
                }
            }
            return codex;
        } 
    } 
}
