#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Proiect.Data;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Pages.PaymentTypes
{
    public class DetailsModel : PageModel
    {
        private readonly Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext _context;

        public DetailsModel(Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext context)
        {
            _context = context;
        }

        public PaymentType PaymentType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaymentType = await _context.PaymentType.FirstOrDefaultAsync(m => m.ID == id);

            if (PaymentType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
