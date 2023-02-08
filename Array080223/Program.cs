using System;
using System.Globalization;
using System.Xml.Schema;

namespace Array080223
{
    internal class Program
    {
        /*
         - creare due array di numeri interi
         - popolare il primo array di numeri casuali
         - copiare tutti gli elementi del primo array nel
         secondo
         - creare un terzo array che contenga gli elementi
         di entrambi gli array
         - stampare gli elementi di tutti e tre gli array
         */
        /*
        static void PrintArray(int[] numeri)
        {
            //foreach(int i in numeri)
            //{
            //    Console.WriteLine(i);   
            //}
            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine(i+1 +" )" +numeri[i]);
            }
        }
        static void Main(string[] args)
        {
            int numeriArray = 5;
            int[] n1 = new int[numeriArray];
            int[] n2 = new int[numeriArray];
            Random random= new Random();

            for(int i=0;i<numeriArray;i++)
                n1[i] = random.Next(100);

            for (int i = 0; i < numeriArray; i++)
                n2[i] = n1[i];

            int dimension = numeriArray * 2;
            int[] n3 = new int[dimension];

            for (int i = 0; i < numeriArray; i++)
                n3[i] = n1[i];
            for (int i = 0; i < numeriArray; i++)
                n3[numeriArray + i] = n2[i];

            PrintArray(n1);
            PrintArray(n2);
            PrintArray(n3);
        }
        */
        /*
        - creare un array di stringhe di dimensione 5
        - popolare l'array con stringhe arbitrarie
        - chiedere all'utente quale stringa vuole stampare
        - stampare su schermo la stringa scelta dall'utente
        */

        /*
        static void Main(string[] args)
        {
            string[] s = new string[5];
            //s[0] = "mango";
            //s[1] = "pera";
            //s[2] = "ananas";
            //s[3] = "kiwi";
            //s[5] = "mela";
            for(int i=0;i<s.Length;i++)
            {
                s[i] = "sono una stringa " + i;
            }
            Console.Write("quale stringa vuole stampare ? ");
            int input = int.Parse(Console.ReadLine());
            if(input>=0 && input<s.Length)
            {
                Console.WriteLine(s[input]);
            }
            
        }
        */

        /*
         - creare una funzione che restituisca un array
         di numeri casuali
         - chiamare la funzione 2 volte e stampare tutti
         i numeri che restituisce
         */

        static int [] GetNumbers()
        {
            Random random= new Random();
            Console.Write("Entri la dimensione dell'array: ");
            int dimensione = int.Parse(Console.ReadLine());

            int[] numeri = new int[dimensione];
            
            for(int i=0;i<dimensione;i++)
            {
                numeri[i] = random.Next(100);
            }
           return numeri;
        }
        static void Main(string[] args)
        {
            for(int i=0;i<2;i++)
            {
                int[] numero = GetNumbers();
                for(int j = 0; j < numero.Length; j++)
                {
                    Console.WriteLine(numero[j]);
                }
            }
        }
    }
}
