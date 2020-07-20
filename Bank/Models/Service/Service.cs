using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Service
    {
        public int Id { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public string BankCard { get; set; }
        public int Amount { get; set; }
    }
}
