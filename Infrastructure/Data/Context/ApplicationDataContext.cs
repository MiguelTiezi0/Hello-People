using Microsoft.EntityFrameworkCore;
using StoreManager.Models;
using System.Collections.Generic;

namespace StoreManager.Infrastructure.Data.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {
        }

        public DbSet<CategoryClient> CategoryClient { get; set; }

    

    }
}
