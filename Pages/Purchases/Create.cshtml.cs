#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ivanov_Ioana_Proiect.Data;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Pages.Purchases
{
    public class CreateModel : PageModel
    {
        private readonly Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext _context;

        public CreateModel(Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PaymentTypeID"] = new SelectList(_context.Set<PaymentType>(), "ID", "PaymentTypeName");
            ViewData["PayeeID"] = new SelectList(_context.Set<Payee>(), "ID", "PayeeName");
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
            var purchase = new Purchase();
            return Page();
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var newPurchase = new Purchase();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Purchase.Add(Purchase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
