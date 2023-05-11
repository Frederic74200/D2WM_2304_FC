// See https://aka.ms/new-console-template for more information

// test



using System.Globalization;
using System.Text;

CultureInfo culture1 = CultureInfo.CurrentCulture;

double value = 15.4;



double test = Math.Ceiling(value); // celling -< supp
Console.WriteLine("test  : " + test);

int test2 = Convert.ToInt32(test);

Console.WriteLine("test 2 : " + test2);

double tesmin = Math.Floor(value);
Console.WriteLine("test min : " + tesmin);

int test3 = Convert.ToInt32(tesmin);
Console.WriteLine("test 3 : " + test3);

