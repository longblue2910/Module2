namespace Student
{
    public class Studen
    {
        private int id;
        private string name;
        private string address;
        private int age;
        public Studen() { }
        public Studen(int _id, string _name, string _address, int _age)
        {
            this.id = _id;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int _id)
        {
            this.id = _id;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int _age)
        {
            this.age = _age;
        }
        public string GetAdress()
        {
            return this.address;
        }
        public void SetAddress(string _address)
        {
            this.address = _address;
        }
        public override string ToString()
        {
            return "Id : " + id + " Name : " + name + " Address : " + address + " Age : " + age;
        }
    }
}