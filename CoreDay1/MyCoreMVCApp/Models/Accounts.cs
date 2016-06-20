using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVCApp.Models
{
    public class Account
    {
        [Display(Name ="Account Number")]
        public int AccNo { get; set; }

        [Display(Name = "Account Balance")]
        public double AccBalance { get; set; }

        [Display(Name = "Account Name")]
        public string AccName { get; set; }

        [Display(Name = "Account Type")]
        public string AccType { get; set; }

        public IList<Account> GetData()
        {
            return new List<Account>() {  new Account() { AccName = "Prijil Faizal Khalil", AccBalance = 10.00, AccNo = 420, AccType = "Theft" },
                                                new Account() { AccName = "Ramesh Mumiddi", AccBalance = 1000.00, AccNo = 1001, AccType = "Savings" },
                                                new Account() { AccName = "Raviteja Bandi", AccBalance = 900.00, AccNo = 1002, AccType = "Savings"},
                                                new Account() { AccName = "Suneela B", AccBalance = 1000.00, AccNo = 1003, AccType = "Savings" },
                                                new Account() { AccName = "Harisha", AccBalance = 1000.00, AccNo = 1004, AccType = "Savings" },};
        }
    }
}
