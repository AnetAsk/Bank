using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string IdentityUser { get; set; }
        public DateTime ValidPeriod { get; set; }
        public string BankCards { get; set; }
    }
}
