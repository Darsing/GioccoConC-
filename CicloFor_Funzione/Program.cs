using System;

namespace CicloFor_Funzione
{
    internal class Program
    {
        /*
         - chiedere all'utente i suoi dati anagrafici
         e tramite un ciclo for stamparli 5 volte
         - tramite una funzione (con return) chiedere
         all'utente un numero e tramite un'altra funzione
         stampare il numero e il quadrato del numero
         */

        /*
        static void PrintNumber(int num)
        {
            Console.WriteLine($"Il numero inserito : {num} " +
                $" il quadrato : {num * num}");
        }
        static int GetNumber()
        {
            Console.Write("Inserisci un numero : ");
            int num = int.Parse(Console.ReadLine());
            return num;   
        }
        static void Main(string[] args)
        {
            Console.Write("Inserisci tuo nome : ");
            string nome = Console.ReadLine();
            Console.Write("Inserisci tuo cognome : ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci un numero : ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ciao {nome} {cognome} , numero inserito : {numero}");
            }

            PrintNumber(GetNumber());   
        }
        */

        /*
         - tramite un ciclo for chiamare 20 volte una
         funzione che abbia un numero in ingresso
         e lo stampi su schermo
         */

        /*
        static int Funzione1(int n)
        {
           return n;
        }
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero :");
            int n = int.Parse(Console.ReadLine());

           for(int i=0; i<20; i++)
            {
                Console.WriteLine(Funzione1(n));
            }
        }

        */

        /*
         tramite l'uso del ciclo for stampare su schermo
         un poligono di lato 10 (caratteri)
         */

        /*
        static void Main(string[] args)
        {
            //primo metodo
            //for(int i=0; i<10; i++)
            //  {
            //      string a = "0000000000";
            //      Console.WriteLine(a);

            //  }

            int dimensione = 4;
            for(int i = 0; i < dimensione; i++)
            {
                string linea = "";
                for(int j = 0; j < dimensione; j++)
                {
                    linea+="0";
                }
                Console.WriteLine(linea);
            }
        }
        */

        /*
         - creare una funzione che restituisca
         una stringa arbitraria
         - tramite una seconda funzione stampare
         su schermo la stringa arbitraria
         */

        /*
        static string StringaArbitraria()
        {
            return "Sono una stringa arbitraria";
        }
        static void PrintStringaArbitraria(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            PrintStringaArbitraria(StringaArbitraria());
        }

        */
        /*
        - tramite un ciclo for stampare su schermo
        25 numeri casuali
        - tramite un secondo ciclo for stampare su
        schermo 25 booleani casuali
        */

        /*
        static void Main(string[] args)
        {
            int numeriMax = 20;
            Random random= new Random();
           for(int i=0; i< numeriMax; i++)
            {
                int n = random.Next(51);  
                Console.WriteLine( i+1 +")" + n);
            }

           for(int i=0;i<numeriMax;i++)
            {
                int b = random.Next(0,2);
                if(b== 0)
                {
                    Console.WriteLine($"{i+1}) true");
                }
                else
                {
                    Console.WriteLine($"{i + 1}) false");
                }
            }

        }
        */

        /*
         - chiedere all'utente due stringhe e stamparle
         su schermo 50 volte ciascuna
         */
        static void Main(string[] args)
        {
            Console.Write("Inserisci una prima : ");
            string input1= Console.ReadLine();
            Console.Write("Inserisci una seconda : ");
            string input2 = Console.ReadLine();

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{input1}");
                Console.WriteLine($"{input2}");
            }
        }

    }
    
}
