using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivanov_Ioana_Proiect.Models
{
    public class Purchase
    {
        public int ID { get; set; }

        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Payment Type")]
        public int PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; } //Navigation property

        [Display(Name = "Payee")]
        public int PayeeID { get; set; } 
        public Payee Payee { get; set; } //Navigation property

        [Display(Name = "Purchase Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; } //Navigation property
        public string Details { get; set; }



    }
}
