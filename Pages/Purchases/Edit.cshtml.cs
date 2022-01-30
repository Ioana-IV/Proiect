#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Proiect.Data;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Pages.Purchases
{
    public class EditModel : PageModel
    {
        private readonly Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext _context;

        public EditModel(Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Purchase = await _context.Purchase.FirstOrDefaultAsync(m => m.ID == id);

            if (Purchase == null)
            {
                return NotFound();
            }
            ViewData["PaymentType"] = new SelectList(_context.Set<PaymentType>(), "ID", "PaymentTypeName");
            ViewData["Payee"] = new SelectList(_context.Set<Payee>(), "ID", "PayeeName");
            ViewData["Category"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Purchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(Purchase.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PurchaseExists(int id)
        {
            return _context.Purchase.Any(e => e.ID == id);
        }
    }
}
