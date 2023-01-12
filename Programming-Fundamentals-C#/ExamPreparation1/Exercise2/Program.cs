using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise2
{
    public class Program
    {
        public static void Main()
        {
            string pattern = "@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            Regex barcodeRegex = new Regex(pattern);
            Regex productGroupRegex = new Regex(@"\d+");

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();
                var match = barcodeRegex.Match(barcode);

                if (match.Success)
                {
                    MatchCollection productGroupMatch = productGroupRegex.Matches(match.Value);
                    if (productGroupMatch.Count > 0) 
                        Console.WriteLine($"Product group: {string.Join("", productGroupMatch)}");
                    else 
                        Console.WriteLine("Product group: 00");
                }
                else 
                    Console.WriteLine("Ïnvalid barcode");
            }
        }
    }
}