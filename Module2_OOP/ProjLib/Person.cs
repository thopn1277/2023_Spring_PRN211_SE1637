namespace ProjLib
{
    public class Person
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime Dob { get; set; }

        internal void InputPerson(int _id, int _name, DateTime _dob)
        {
            Id = _id;
            Name = _name;
            Dob = _dob;
        }

        public override string? ToString()
        {
            return $"ID: {Id}, Name: {Name}, Dob: {Dob:dd/MM/yyyy}";
        }
    }
}