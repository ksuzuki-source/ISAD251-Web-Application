﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISAD251WebApp.Models;

namespace ISAD251WebApp.Views
{
    public class DeleteModel : PageModel
    {
        private readonly ISAD251WebApp.Models.StoredContext _context;

        public DeleteModel(ISAD251WebApp.Models.StoredContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FindAsync(id);

            if (Products != null)
            {
                _context.Products.Remove(Products);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
