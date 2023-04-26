namespace ex_2_4_tri_3_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // variables  -----------------------------------------------------------------------------------
            int a;
            int b;
            int c;

            String saisie;
            bool saisieOk;

            



            // traitement --------------------------------------------------------------------------------

            Console.WriteLine("Programme de classement de 3 nombres entiers dans l'ordre croissant");

            // vérification saisie -----------

            do
            {
                Console.WriteLine("Veuillez saisir le premier nombre : ");
                saisie = Console.ReadLine();  
                saisieOk = int.TryParse(saisie, out a);

                if (!saisieOk)
                {
                    Console.WriteLine("Saise incorrecte ! Veuillez recommencer.");
                }
            } while (!saisieOk);

            saisieOk = false;
            do
            {
                Console.WriteLine("Veuillez saisir le deuxième nombre : ");
                saisie = Console.ReadLine();
                saisieOk = int.TryParse(saisie, out b);

                if (!saisieOk)
                {
                    Console.WriteLine("Saise incorrecte ! Veuillez recommencer.");
                }
            } while (!saisieOk);

            saisieOk = false;

            do
            {
                Console.WriteLine("Veuillez saisir le troisième nombre : ");
                saisie = Console.ReadLine();
                saisieOk = int.TryParse(saisie, out c);

                if (!saisieOk)
                {
                    Console.WriteLine("Saise incorrecte ! Veuillez recommencer.");
                }
            } while (!saisieOk);


            // classement nombres ------------

            if (a > b)
            {
                if (c > a)
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + c + ", " + a + ", " + b);
                }
                else if (c > b && c < a)
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + a+ ", " + c + ", " + b);
                }
                else
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + a + ", " + b + ", " + c);
                }
            } // fin grand if 1


            if (b > a)
            {
                if (c > b)
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + c + ", " + b + ", " + a);
                }
                else if (c > a && c < b)
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + b + ", " + c + ", " + a);
                }
                else
                {
                    Console.WriteLine("L'ordre décroissant des nombres est : " + b + ", " + a + ", " + c);
                }
            } // fin grand if 2


            // fin traitement , fin programme -------------------------------------------------------------

            Console.WriteLine("Appuyez sur une touche pour fermer le programme");
            Console.ReadLine();

        }
    }
}