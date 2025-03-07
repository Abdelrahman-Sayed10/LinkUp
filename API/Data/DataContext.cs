using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

//Primary Constructor
public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}   
