using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Query_Logs_DCA.Data;
using Query_Logs_DCA.Models;

namespace Query_Logs_DCA.Pages.Queries
{
    public class DeleteModel : PageModel
    {
        private readonly Query_Logs_DCA.Data.Query_Logs_DCAContext _context;

        public DeleteModel(Query_Logs_DCA.Data.Query_Logs_DCAContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Query Query { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Query == null)
            {
                return NotFound();
            }

            var query = await _context.Query.FirstOrDefaultAsync(m => m.Id == id);

            if (query == null)
            {
                return NotFound();
            }
            else 
            {
                Query = query;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Query == null)
            {
                return NotFound();
            }
            var query = await _context.Query.FindAsync(id);

            if (query != null)
            {
                Query = query;
                _context.Query.Remove(Query);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
