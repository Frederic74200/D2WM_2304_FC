// See https://aka.ms/new-console-template for more information

// test



using System.Globalization;
using System.Text;

CultureInfo culture1 = CultureInfo.CurrentCulture;

String value = "310,16";
try
{
    Console.WriteLine("{0} culture reflects user overrides: {1}",
                      culture1.Name, culture1.UseUserOverride);
    Decimal amount = Decimal.Parse(value, culture1);
    Console.WriteLine("'{0}' --> {1}", value, amount.ToString(CultureInfo.InvariantCulture));
}
catch (FormatException)
{
    Console.WriteLine("Unable to parse '{0}'", value);
}
Console.WriteLine();
