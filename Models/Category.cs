namespace Ivanov_Ioana_Proiect.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Category> Categories { get; set; } //Navigation Property
    }
}
