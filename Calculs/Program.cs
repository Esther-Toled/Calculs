using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static int valeur()
        {
            Random rand = new Random(); // outil de génération de nombre aléatoire

            // création des 2 nombres aléatoires
            int val;
            Console.WriteLine("entrer un chiffre");
            val = int.Parse(Console.ReadLine());
            return val;
        }
        static void Main(string[] args)
        {
            // variables
            int val1, val2;
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = "1";
           

            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();

                // traitement des choix
                if (choix != "0")
                {
                    //appelation de la fonction
                    val1 = valeur();
                    val2 = valeur();

                    if (choix == "1")
                    {
                        // choix de l'addition
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());

                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo!");
                        }
                        else
                        {
                            Console.WriteLine("Faux: " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix == "2")
                    {
                        // choix de la multiplication
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());

                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo!");
                        }
                        else
                        {
                            Console.WriteLine("Faux: " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choix invalide.");
                    }
                }
            }
        }
    }
}
   
