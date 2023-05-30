namespace ProcedureFonction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProcedureFonction prfc1 = new ProcedureFonction();
            ProcedureFonction prfc2 = new ProcedureFonction(3.14, 44.045, "Lilly");

            Console.WriteLine("Somme 1 : " + prfc1.AdditionnerDeuxNombresReels());
            Console.WriteLine("Somme 2 : " + prfc2.AdditionnerDeuxNombresReels());
            prfc1.AfficherBonjourEtPrenom();
            prfc2.AfficherBonjourEtPrenom();    




        }
    }
}