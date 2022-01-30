namespace Ivanov_Ioana_Proiect.Models
{
    public class PaymentType
    {
        public int ID { get; set; }
        public string PaymentTypeName { get; set; }
        public decimal AvailableAmmount { get; set; }
        public ICollection<PaymentType> PaymentTypes { get; set; } //Navigation Property
    }
}
