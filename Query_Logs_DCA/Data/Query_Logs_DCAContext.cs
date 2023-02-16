using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Query_Logs_DCA.Models;

namespace Query_Logs_DCA.Data
{
    public class Query_Logs_DCAContext : DbContext
    {
        public Query_Logs_DCAContext (DbContextOptions<Query_Logs_DCAContext> options)
            : base(options)
        {
        }

        public DbSet<Query_Logs_DCA.Models.Query> Query { get; set; } = default!;
    }
}
