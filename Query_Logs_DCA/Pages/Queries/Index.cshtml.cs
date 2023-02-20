using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Query_Logs_DCA.Data;
using Query_Logs_DCA.Models;

namespace Query_Logs_DCA.Pages.Queries
{
    public class IndexModel : PageModel
    {
        private readonly Query_Logs_DCA.Data.Query_Logs_DCAContext _context;

        public IndexModel(Query_Logs_DCA.Data.Query_Logs_DCAContext context)
        {
            _context = context;
        }

        public IList<Query> Query { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Category_of_Query { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Genre_of_Query { get; set; }


        public async Task OnGetAsync()
        {
            if (_context.Query != null)
            {
                Query = await _context.Query.ToListAsync();
            }
        }
    }
}
