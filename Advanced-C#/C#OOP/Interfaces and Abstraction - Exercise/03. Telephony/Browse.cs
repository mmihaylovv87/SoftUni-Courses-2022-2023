namespace _03._Telephony
{
    public class Browse
    {
        public Browse(string url)
        {
            this.URL = url;   
        }

        public string URL { get; set; }

        public override string ToString()
        {
            return $"Browsing: {this.URL}!";
        }
    }
}
