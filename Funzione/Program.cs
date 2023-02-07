using System;

namespace Funzione
{
    internal class Program
    {
        /*
         usando qualsiasi mezzo studiato a lezione, costruire una
         calcolatrice con le 4 operazioni fondamentali
         - idealmente gestire un loop infinito che permette di
         eseguire più operazioni..
         */

        /*creare le funzioni Somma e Differenza utilizzando parametri
         in ingresso, return e altri mezzi a piacere*/
        static int GetSomma(int n1, int n2)
        {
            return n1 + n2;
        }
        static int GetDifferenza(int n1, int n2)
        {
            return n1 - n2; 
        }
        static void Main(string[] args)
        {
            Console.Write("Inserisci il primo numero : ");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero : ");
            int n2 = int.Parse(Console.ReadLine());

            int somma = GetSomma(n1, n2);   
            Console.WriteLine($"La somma : {somma}");
            Console.WriteLine(GetDifferenza(n1, n2));

        }
    }
}
