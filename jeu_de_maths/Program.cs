using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }

        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;
            while (true)
            {
                Random rnd = new Random();
                int a = rnd.Next(min, max+1);
                int b = rnd.Next(min, max+1);
                e_Operateur o = (e_Operateur)rnd.Next(1, 3);
                int resultatAttendu;

                switch (o)
                {
                    case e_Operateur.ADDITION:
                        Console.Write(a + " + " + b + " = ");
                        resultatAttendu = a + b;
                        break;
                    case e_Operateur.MULTIPLICATION:
                        Console.Write(a + " X " + b + " = ");
                        resultatAttendu = a * b;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.Write(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.WriteLine("ERREUR : opérateur inconnu");
                        return false;
                }

                /*if (o == e_Operateur.ADDITION)
                {
                    Console.Write(a + " + " + b + " = ");
                    resultatAttendu = a + b;
                }
                else if (o == e_Operateur.MULTIPLICATION)
                {
                    Console.Write(a + " X " + b + " = ");
                    resultatAttendu = a * b;

                }
                else if (o == e_Operateur.SOUSTRACTION)
                {
                    Console.Write(a + " - " + b + " = ");
                    resultatAttendu = a - b;
                }
                else
                {
                    Console.WriteLine("ERREUR : opérateur inconnu");
                    return false;
                }
                */



                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (resultatAttendu == reponseInt)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }

            }
            
        }
        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 5;

            int points = 0;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n°" + (i+1) + "/" + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse");
                    points--;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points + "/" + NB_QUESTIONS);

            int moyenne = NB_QUESTIONS / 2;

            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("EXELLENT");
            } 
            else if (points == 0)
            {
                Console.WriteLine("Réviser vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("pas mal");
            }
            else 
            {
                Console.WriteLine("Peut mieux faire");
            }
            
        }
    }
}