using System;
using Microsoft.EntityFrameworkCore;

namespace MySql.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

}
