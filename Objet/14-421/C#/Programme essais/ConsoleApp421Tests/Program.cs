namespace ConsoleApp421Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int precedent = 1;
            int nombre =1;
            int suivant ;

            int randPrec= 1;
            int rand =0;

            int min = 1;
            int max = 6;

            List<int> fibo = new List<int>();
            List<int> prem = new List<int> {  3, 5, 7, 11, 13, 17, 19 };


            string q;



            for (int i = 0; i < 7; i++)
            {

                suivant = precedent + nombre;
                fibo.Add(suivant);  
                precedent = nombre;

                nombre = suivant;


            }

            do
            {

             
                    bool ok = false;
                    do
                    {
                        int n = fibo[randPrec];
                        int x = prem[rand];

                        rand = (x * n) % max;

                        if (rand > min) { ok = true; }
                        else
                        {
                            randPrec ++;
                        }

                    } while (!ok);

                

                randPrec = rand-1;


                Console.WriteLine("nb : " + rand.ToString());
                 q = Console.ReadLine();

            } while (q != "q"); 



        }
    }
}