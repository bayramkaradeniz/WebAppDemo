using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppDemo.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberCategory> MemberCategories { get; set; }
    }
}