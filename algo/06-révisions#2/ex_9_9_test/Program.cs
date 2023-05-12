using System.Globalization;

namespace ex_9_9_test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CultureInfo culture1 = CultureInfo.CurrentCulture;
            var textinfo = culture1.TextInfo;


            List<string> legumes = new List<string>();
            List<int> tableau2 = new List<int>();


            //  tableau1.Add(tableauDepart[i]);


            String test = "frederic";
            string test2 = textinfo.ToTitleCase(test);
            Console.WriteLine(test2);
           Console.WriteLine("test2 0 " + test2[0]);


            NumberFormatInfo nfi = culture1.NumberFormat;

            double nb = 69.000;

            bool ok;
            nfi.CurrencyDecimalDigits = 2;






           
        }
    }
}