using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ValidPeriod { get; set; }
        public string CardHolder { get; set; }
        public int Cvc { get; set; }
        public int Amount { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
