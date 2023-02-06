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

        /*
        static void ProvaSwitch()
        {
            int scelta;
            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("0 - ti saluta");
            Console.WriteLine("1 - faccio la somma fra 2 numeri");
            Console.WriteLine("Scelgo l'opzione: )");
            scelta = int.Parse(Console.ReadLine());


            //if(scelta==0 )
            //{
            //    Console.WriteLine("Ciao amico");
            //}
            //else if(scelta==1 )
            //{
            //    int n1, n2;
            //    Console.WriteLine("Inserisci il primo numero");
            //    n1=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Inserisci il secondo numero");
            //    n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"La somma di {n1} + {n2} = {n1+n2}");
            //}

            switch (scelta)
            {
                case 0:
                    Console.WriteLine("Ciao amico");
                    break;
                case 1:
                    int n1, n2;
                    Console.WriteLine("Inserisci il primo numero");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il secondo numero");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La somma di {n1} + {n2} = {n1 + n2}");
                    break;
                default:
                    Console.WriteLine("Non hai scelto niente");
                    break;
            }
        }
        */
        /*
        static void Calculatice()
        {
            float n1;
            float n2;
            int scelta;

            while (true)
            {
                
                Console.WriteLine("Benvenuto nella mia calculatrice \ncosa  vuoi fare ?");
                Console.WriteLine("0 - Somma \n1 - Differenza \n2 - Multiplicazione " +
                    "\n3 - Divisione \n4 - Esci");

                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 0:
                        Console.Write("Inserisci il primo numero :");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero :");
                        n2 = float.Parse(Console.ReadLine());
                        float somma = n1 + n2;
                        Console.WriteLine($"La somma di {n1} + {n2} = {somma}");
                        break;
                        
                    case 1:
                        Console.Write("Inserisci il primo numero :");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero :");
                        n2 = float.Parse(Console.ReadLine());
                        float differenza = n1 - n2;
                        Console.WriteLine($"La somma di {n1} - {n2} = {differenza}");
                        break;
                    case 2:
                        Console.Write("Inserisci il primo numero :");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero :");
                        n2 = float.Parse(Console.ReadLine());
                        float moltiplicazione = n1 * n2;
                        Console.WriteLine($"La somma di {n1} x {n2} = {moltiplicazione}");
                        break;
                    case 3:
                        Console.Write("Inserisci il primo numero :");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero :");
                        n2 = float.Parse(Console.ReadLine());
                        float divisione = n1 / n2;
                        Console.WriteLine($"La somma di {n1} / {n2} = {divisione}");
                        break;
                    case 4:
                        //per uscire 
                        return;
                }
                
            }
        */

        static void Main(string[] args)
        {
            //MassiFunzione();
           // ProvaSwitch();  
          // Calculatice();


            Console.ReadKey();
        }
    }
}
