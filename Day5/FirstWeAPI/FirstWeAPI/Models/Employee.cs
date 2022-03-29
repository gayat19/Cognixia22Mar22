namespace FirstWeAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override bool Equals(object obj)
        {
            Employee e1, e2;
            e1 = this;
            e2 = (Employee)obj;
            return e1.Id == e2.Id;
           
        }
    }
}
