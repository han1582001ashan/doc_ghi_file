namespace DEMOFILE
{
    public class Address
    {
        private string road;
        private string city;
        public Address() { }
        public Address(string road, string city)
        {
            this.Road = road;
            this.City = city;
        }
        public string Road { get => road; set => road = value; }
        public string City { get => city; set => city = value; }
    }
}