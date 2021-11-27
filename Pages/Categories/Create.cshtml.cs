﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moldovan_Andreea_Lab8.Data;
using Moldovan_Andreea_Lab8.Models;

namespace Moldovan_Andreea_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Moldovan_Andreea_Lab8.Data.Moldovan_Andreea_Lab8Context _context;

        public CreateModel(Moldovan_Andreea_Lab8.Data.Moldovan_Andreea_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}