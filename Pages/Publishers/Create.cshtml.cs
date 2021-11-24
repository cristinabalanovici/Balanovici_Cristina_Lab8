using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Balanovici_Cristina_Lab8.Data;
using Balanovici_Cristina_Lab8.Models;

namespace Balanovici_Cristina_Lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Balanovici_Cristina_Lab8.Data.Balanovici_Cristina_Lab8Context _context;

        public CreateModel(Balanovici_Cristina_Lab8.Data.Balanovici_Cristina_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
