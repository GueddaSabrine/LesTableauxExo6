using System;

namespace LesTableauxExo6
{
    class Program
    {

        enum Week
        {
            Lundi, //valeur0
            Mardi, //valeur1
            Mercredi, //valeur2
            Jeudi, //valeur3
            Vendredi, //valeur4
            Samedi, //valeur5
            Dimanche //valeur6
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine((Week)i);
            }
            
            //Console.WriteLine(Enum.GetName(typeof(Week), 4));
            //Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(4));
            Console.WriteLine((Week)4);            
        }
    }
}


   //Afficher tous les éléments de week dans la console.
        //Dans une nouvelle ligne, afficher la valeur 4 de l’énumération week.
