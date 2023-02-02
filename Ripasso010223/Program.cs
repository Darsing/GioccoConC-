using System;

namespace Ripasso010223
{
    internal class Program
    {
        //come calcolare il massimo minimo e media di numeri in un array
        /*
        static void MassiFunzione()
        {
            int[] numeri = new int[10];
            int x;
            int minimo;
            int massimo;
            float media;

            do
            {
              Console.Write("Quanti numeri vuoi inserire ? ");
              x = int.Parse(Console.ReadLine()); 
            }
            while (x > 10);

            for(int i=0; i<x; i++)
            {
                Console.Write($"Inserisci il {i+1} numero : ");
                numeri[i]= int.Parse(Console.ReadLine());
            }

            //massimo  minimo e media
            massimo = numeri[0];
            minimo = numeri[0];
            media = numeri[0];  
            for(int i = 1; i < x; i++)
            {
                if (numeri[i] > massimo)
                {
                    massimo = numeri[i];
                }
                else
                {
                    if (numeri[i] < minimo)
                    {
                        minimo = numeri[i];
                    }
                }
                media += numeri[i];
            }
            media = media / x;

            Console.WriteLine($"Il massimo è : {massimo}");
            Console.WriteLine($"Il minimo è : {minimo}");
            Console.WriteLine($"La media è : {media}");

        }
        */

        static void Main(string[] args)
        {
            //MassiFunzione();
            int scelta;
            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("0 - ti saluta");
            Console.WriteLine("1 - faccio la somma fra 2 numeri");
            Console.WriteLine("Scelgo l'opzione: )");
            scelta= int.Parse(Console.ReadLine());
            Console.WriteLine($"Hai scelta opzione numero {scelta}");

            if(scelta==0 )
            {
                Console.WriteLine("Ciao amico");
            }
            else if(scelta==1 )
            {
                int n1, n2;
                Console.WriteLine("Inserisci il primo numero");
                n1=int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"La somma di {n1} + {n2} = {n1+n2}");
            }

            Console.ReadKey();
        }
    }
}
