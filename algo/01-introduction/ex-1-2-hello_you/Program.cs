namespace ex_1_2_hello_you
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String prenom;

            Console.WriteLine("Bonjour, Veuillez saisir votre prénom : ");

            prenom = Console.ReadLine();

            Console.WriteLine("Bonjour " + prenom + ".");
        }
    }
}