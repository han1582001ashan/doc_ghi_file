namespace DEMOFILE
{
    public class Person
    {
        private string name;
        private DateTime birth;
        private Address address;
        public Person(){}
        public Person(string name, DateTime birth, Address address)
        {
            this.name = name;
            this.birth = birth;
            this.address = address;
        }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public Address Address { get => address; set => address = value; }
    }
}