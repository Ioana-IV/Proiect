namespace Ivanov_Ioana_Proiect.Models
{
    public class Payee
    {
        public int ID { get; set; }
        public string PayeeName { get; set; }
        public ICollection<Payee> Payees { get; set; } //Navigation Property
    }
}
