namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private

        public Person()
        {

        }

        public string Name 
        { 
            get { return this.name; }
            private set
            {
                this.name = value;
            }
        }
        public decimal Money 
        { 
            get { return this.money; }
            private set
            {
                this.money = value;
            }
        }
    }
}