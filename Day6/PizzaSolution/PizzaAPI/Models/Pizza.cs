namespace PizzaAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public override bool Equals(object obj)
        {
            Pizza p1, p2;
            p1 = this;
            p2 = (Pizza)obj;
            return p1.Id.Equals(p2.Id);
        }
    }
}
