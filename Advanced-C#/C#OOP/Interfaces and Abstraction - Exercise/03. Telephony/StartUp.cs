using System;

namespace _03._Telephony
{
    public class StartUp
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            foreach (string phoneNumber in phoneNumbers)
            {
                if (IsValidPhoneNumber(phoneNumber))
                {
                    if (phoneNumber.Length == 10)
                    {
                        ICall smartphone = new Smartphone(phoneNumber);
                        Console.WriteLine(smartphone);
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        ICall stationaryPhone = new StationaryPhone(phoneNumber);
                        Console.WriteLine(stationaryPhone);
                    }
                }
                else 
                    Console.WriteLine("Invalid number!");
            }

            string[] urls = Console.ReadLine() .Split();
            foreach (string url in urls)
            {
                if (IsValidURL(url))
                {
                    Browse browse = new Browse(url);
                    Console.WriteLine(browse);
                }
                else
                    Console.WriteLine("Invalid URL!");
            }
        }

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            foreach (char ch in phoneNumber)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }

        static bool IsValidURL(string url)
        {
            foreach (char ch in url)
            {
                if (char.IsDigit(ch))
                    return false;
            }
            return true;
        }
    }
}