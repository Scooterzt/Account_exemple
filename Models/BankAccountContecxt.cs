using System;
using System.ComponentModel.DataAnnotations;
using BankAccount.Models;
using Microsoft.EntityFrameworkCore;
 
namespace BankAccount.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Transactions> transactions {get;set;}
    }
}