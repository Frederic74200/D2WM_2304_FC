using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Text.RegularExpressions;

namespace ex_9_9_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string imput = "è à ù ô ç";
            string oputput;

            imput = imput.ToLower();


            imput.Replace('à', 'a');
            imput.Replace('é', 'e');
            imput.Replace('î', 'i');
            imput.Replace('ô', 'o');
            imput.Replace('ù', 'u');
            imput.Replace('ç', 'c');


            

            Console.WriteLine(imput);

        }
    }
}