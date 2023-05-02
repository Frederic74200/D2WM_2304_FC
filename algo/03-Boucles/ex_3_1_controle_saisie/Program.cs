namespace ex_3_1_controle_saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String prenom;
            int nombreMiniChar = 2;
            bool saisieOK;
            int nombreCharPrenon;


            do
            {
                Console.WriteLine("Saisissez votre prénom : ");
                prenom = Console.ReadLine();

                nombreCharPrenon = prenom.Length;

                if (nombreCharPrenon <= nombreMiniChar)
                {
                    saisieOK = false;
                }
                else
                {
                    saisieOK = true;
                }
            } while (!saisieOK);


            Console.WriteLine("Bonjour " + prenom);
            Console.WriteLine(prenom.Length + " " + saisieOK);
        }
    }
}