using System;




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          string str = "", ruekw = "", wort=""; 
            int w = 0;
            Console.WriteLine("Geben Sie ein Wort ein");
            str = Console.ReadLine();
            wort = str;
            w = str.Length - 1;
            while (w>= 0)
            {
                ruekw = ruekw + wort[w];
                w--;
            }
            Console.WriteLine("Eingegebenes Wort ist = " + wort);
            Console.WriteLine("Umgekehrt ist es = " + ruekw);
            if (ruekw == wort)
            {
                Console.WriteLine("Das Wort ist ein Palindrom");
            }
            else
            {
                Console.WriteLine("Das Wort ist kein Palindrom");
            }
            Console.ReadLine();
        }
    
    }
}
