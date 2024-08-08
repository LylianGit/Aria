using System;

public class Example
{
    public static void Main()
    {
        while (1 == 1)
        {
            Console.WriteLine("Force : ");
            double f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dexterité : ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Endurance : ");
            double e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Intelligence : ");
            double i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Charisme : ");
            double c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artisanat, construire : {0}", Calcul(d, i));
            Console.WriteLine("Combat rapproché : {0}", Calcul(f, d));
            Console.WriteLine("Combat à distance : {0}", Calcul(d, i));
            Console.WriteLine("Connaissance de la nature : {0}", Calcul(d, i));
            Console.WriteLine("Connaissance des secrets : {0}", Calcul(i, c));
            Console.WriteLine("Courir sauter : {0}", Calcul(d, e));
            Console.WriteLine("Discrétion : {0}", Calcul(d, c));
            Console.WriteLine("Droit : {0}", Calcul(i, c));
            Console.WriteLine("Esquiver : {0}", Calcul(d, i));
            Console.WriteLine("Intimider : {0}", Calcul(f, c));
            Console.WriteLine("Lire, écrire : {0}", Calcul(i, c));
            Console.WriteLine("Mentir, convaincre : {0}", Calcul(i, c));
            Console.WriteLine("Perception : {0}", Calcul(i, c));
            Console.WriteLine("Piloter : {0}", Calcul(d, e));
            Console.WriteLine("Psychologie : {0}", Calcul(e, i));
            Console.WriteLine("Réflexes : {0}", Calcul(d, e));
            Console.WriteLine("Serrures et pièges : {0}", Calcul(d, i));
            Console.WriteLine("Soigner : {0}", Calcul(i, c));
            Console.WriteLine("Survie : {0}", Calcul(e, i));
            Console.WriteLine("Voler : {0}", Calcul(i, c));

            Console.WriteLine(Calcul(d, i));
            Console.WriteLine(Calcul(f, d));
            Console.WriteLine(Calcul(d, i));
            Console.WriteLine(Calcul(d, i));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(d, e));
            Console.WriteLine(Calcul(d, c));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(d, i));
            Console.WriteLine(Calcul(f, c));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(d, e));
            Console.WriteLine(Calcul(e, i));
            Console.WriteLine(Calcul(d, e));
            Console.WriteLine(Calcul(d, i));
            Console.WriteLine(Calcul(i, c));
            Console.WriteLine(Calcul(e, i));
            Console.WriteLine(Calcul(i, c));

            if (f + d + e + i + c != 60)
            {
                Console.WriteLine("Nombre de points en trop : {0}", (f + d + e + i + c) - 60);
            }

            Console.WriteLine("-------------------------------------------------------------------------------");
        }        
    }

    public static double Calcul(double a, double b)
    {
        double c = (a + b) / 2 * 100 / 20;
        if (c % 2 == 1 || c % 2 == 0)
            return c;
        else
            return c - 2.5;
    }
}