using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BankAccount.Models{
    public class UserTransaction{
    public User user {get;set;}
    public Transactions transactions {get;set;}
    }
}