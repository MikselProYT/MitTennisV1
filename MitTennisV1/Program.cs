using System;
using System.Runtime.CompilerServices;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program navn: Tennis
            // Programbeskrivelse: Dette program er et spil, hvor brugeren kan vælge mellem at spille pingpong eller tennis. Programmet vil derefter starte det valgte spil.

            // Fortatter: Mikkel Lengård.

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hej Bruger dette er pingpong eller Tennis");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Skriv 'pingpong' for fuck spille pingpong eller 'tennis' for at spille tennis");
            Thread.Sleep(10000000);
            
            
        }
    }
}