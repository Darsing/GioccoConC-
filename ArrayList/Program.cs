using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ArrayList
{
    internal class Program
    {
        static void AffichesVilles(List<string> villes)
        {
            for(int i=0;i<villes.Count;i++)
            {
                Console.WriteLine(villes[i]);
            }
        }
        static void ListesDesListes()
        {
            //France : Paris, Toulouse, Nice, Bordeaux, Lille
            //Etats-unis : New-york, Chicago, Los angeles, San Francisco
            //Espagne : Madrid, Barcelone, Séville
            //Italie : Venise, Florence, Milan, Pise

            //var villes = new List<string>();
            //villes.Add("France : Paris, Toulouse, Nice, Bordeaux, Lille");
            //villes.Add("Etats-unis : New-york, Chicago, Los angeles, San Francisco");
            //AffichesVilles(villes);

            //faisons une liste de liste 
            var pays= new List<List<string>>(); 
            pays.Add(new List<string>() { "France", "Paris", "Toulouse", "Nice", "Bordeau"});
            pays.Add(new List<string>() { "Espagne", "Madrid", "Barcelone","Séville" }) ;
            pays.Add(new List<string>() {"Italie", "Venise" , "Florence", "Milan", "pise"});

            for(int i = 0; i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine(p[0] + " - " + (p.Count-1) + " villes");
                for(int j=1;j<p.Count;j++)
                {
                    Console.WriteLine(p[j]);
                }
            }
        }
       //dictionary
       static void Dictionnaire()
        {
            //string personneAchercher = "Maria";
            //var dict = new Dictionary<string, string>();
            //dict.Add("Jean","07896");
            //dict.Add("Paul", "04596");
            //dict.Add("Maria", "78896");

            //if (dict.ContainsKey(personneAchercher))
            //{
            //    Console.WriteLine(dict[personneAchercher]);
            //}
            //else
            //{
            //    Console.WriteLine("cette personne n a pas ete trouvée");
            //}

            //var r = new List<List<string>>(); //comment ecrit
            string personneAchercher = "Jean";
            var l = new List<string[]>();
            l.Add(new string[] {"Jean", "07896"});
            l.Add(new string[] {"Paul", "04596"});
            l.Add(new string[] { "Maria", "578596" });

            for(int i = 0; i < l.Count; i++)
            {
                //var n = l[i];
                //Console.WriteLine( n[0] + " "+ l[i][1]);
                if (l[i][0] == personneAchercher)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }
        }
       
        static void Main(string[] args)
        {
            //ListesDesListes();
            Dictionnaire();
        }
    }
}
