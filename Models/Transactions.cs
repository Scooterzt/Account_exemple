using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
namespace BankAccount.Models{
    public class Transactions{
        public int TransactionsId {get;set;}
        [Required]
        public decimal Amount {get;set;}
        public int UserId {get;set;}
        public User Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
    }
}