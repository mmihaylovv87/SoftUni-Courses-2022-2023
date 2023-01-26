using System;

namespace _03._Telephony
{
    public class StationaryPhone : ICall
    {
        public StationaryPhone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; }

        public override string ToString()
        {
            return $"Dialing... {this.PhoneNumber}";
        }
    }
}