using System;
using System.ComponentModel;

namespace esercizi1_funzione_ciclo
{
    internal class Program
    {
        /*
        creare due funzioni con queste caratteristiche:
            1)- accetti in ingresso una stringa e un numero intero
              - stampi la concatenazione della stringa e del numero
              - stampi il numero al quadrato
            2)- accetti in ingresso due booleani
              - stampi su schermo se entrambi i booleani sono true
         */

        /*
        static int PrintFunzione(string stringa,int num)
        {
            Console.WriteLine($"Io sono {stringa} il numero : {num}");
            return num* num;
            
        }
        static void PrintBooleano(bool a, bool b)
        {
            if(a && b)
            {
                Console.WriteLine("Entrambe sono true");
            }
            else
            {
                Console.WriteLine("Entrambi non sono true");
            }
        }
        static void Main(string[] args)
        {
            string s = "Sono una stringa";
            int n = 4;
            bool a = true;  
            bool b = true; 
            PrintFunzione(s,n);
            Console.WriteLine(n*n);
            PrintBooleano(a,b);
            
        }
        */
        /*
         - tramite una funzione generare 3 numeri casuali compresi
            tra 0 e 10
         - tramite una seconda funzione stampare su schermo la somma
         e il prodotto dei tre numeri
         */

        /*
        static void PrintNumberRandom(int[]nums)
        {
            int somma = 0;
            int prodotto = 1;
            for(int i=0;i<nums.Length;i++)
            {
                somma += nums[i];   
                prodotto*= nums[i]; 
               
            }
            Console.WriteLine($"La somma : {somma} , Prodotto : {prodotto}");
        }
        static void Main(string[] args)
        {
            Random r= new Random(); 
            int n1= r.Next(0,11);   
            int n2= r.Next(0,11);
            int n3 = r.Next(0,11);
            int[] nums= {n1,n2,n3};
            Console.WriteLine($"I numeri sono :\n{n1} \n{n2} \n{n3} ");
            PrintNumberRandom(nums);

        }
        */
        /*
          creare una funzione che:
             - accetti in ingresso 2 stringhe
             - stampi su schermo quella di lunghezza maggiore
             - stampi su schermo se la prima contiene la seconda
          */

        /*
        static void PrintStringLength(string s1, string s2)
        {
            if(s1.Length> s2.Length)
            {
                Console.WriteLine($"La stringa s1 è piu grande");
            }
            else
            {
                Console.WriteLine($"La stringa s2 è più piccola");
            }
            if (s1.Contains(s2)){
                Console.WriteLine($"La prima stringa contiene la seconda");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la prima striga");
            string s1=Console.ReadLine();
            Console.WriteLine("Inserisci la seconda striga");
            string s2 = Console.ReadLine();
            PrintStringLength(s1, s2);

        }
        */

        /*
         - chiedere all'utente 2 stringhe e un numero
         - tramite una funzione stampare su schermo il numero moltiplicato
         per 10 e per 20
         - tramite una seconda funzione stampare su schermo il 5° carattere
         della prima stringa
         - tramite una terza funzione stampare su schermo la lettera finale
         della seconda stringa
         */
        static void CalcoloSomma(int n1)
        {
            int num1 = n1 * 10;
            int num2 = n1 * 20;
            Console.WriteLine(num1+ "\n" +num2 );
        }

        static void StampaStringaFive(string s1)
        {
            if (s1.Length >= 4)
            {
                Console.WriteLine($"{s1[4]}");
            }
            else
            {
                Console.WriteLine("Error string deve avere più di 4 carattere");
            }
            
        }
       static void PrintLetterLast(string s2)
        {
            if(!string.IsNullOrEmpty(s2))
            {
                Console.WriteLine(s2.LastIndexOf(s2)); 
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci la prima striga");
            string s1 = Console.ReadLine();
            Console.WriteLine("Inserisci la seconda striga");
            string s2 = Console.ReadLine();
            Console.WriteLine("Inserisci un numero");
            int n1= int.Parse(Console.ReadLine());

            CalcoloSomma(n1);
            StampaStringaFive(s1);
            PrintLetterLast(s2);
        }
    }
}
