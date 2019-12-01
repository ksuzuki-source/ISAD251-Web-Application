using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISAD251WebApp.Models;

namespace ISAD251WebApp.Views
{
    public class DetailsModel : PageModel
    {
        private readonly ISAD251WebApp.Models.StoredContext _context;

        public DetailsModel(ISAD251WebApp.Models.StoredContext context)
        {
            _context = context;
        }

        public Orders Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.FirstOrDefaultAsync(m => m.OrderId == id);

            if (Orders == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
