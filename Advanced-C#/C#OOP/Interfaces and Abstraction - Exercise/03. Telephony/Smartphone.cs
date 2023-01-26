using System;

namespace _03._Telephony
{
    public class Smartphone : ICall
    {
        public Smartphone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; }

        public override string ToString()
        {
            return $"Calling... {this.PhoneNumber}";
        }
    }
}