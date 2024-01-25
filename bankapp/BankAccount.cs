using bankapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bankapp
{
     public class BankAccount
    {
        public string Number { get; }
        public string Name { get; set; }
        public string Remarks { get; }
        public decimal Amount { get
            {
                decimal balance = 0;
                foreach (var item in somevar)
                {

                    balance += item.Amount;

                }
                return balance;
            }
        }

        //static for it will be available for different instances of the BankAccount class.
        private static int initialseed = 1234567890;

        public BankAccount(string name,decimal initialAmount,string remarks) {
        this.Name = name;
            this.Remarks = remarks;
            MakeDeposit(initialAmount,DateTime.Now,remarks);
        this.Number = initialseed.ToString();
            initialseed++;//seed will be increased and not same for another class
            
        }

        private List<Transcations> somevar = new List<Transcations>();


        public void MakeDeposit(decimal amount,DateTime date,string note)
        {
            
             
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount),"negative payments not allowed");
            }
            var deposit = new Transcations(amount, date, note);
            somevar.Add(deposit);

        }

        public void WithdrawDeposit(decimal amount,DateTime date,string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "cann't be withdrawn for neg transcations");
            }
            if(Amount-amount < 0)
            {
                throw new InvalidOperationException("trying to withdraw unavailable sum of money");

            }
            var withdraw = new Transcations(-amount, date,note);
            somevar.Add(withdraw);
        }

        public string HistoryTranscations()
        {
            var lastresult = new StringBuilder();
            lastresult.Append("Date\t\t\tAmount\t\tnote\t\n");
            foreach (var result in somevar)
            {
                lastresult.Append($"{result.Date}\t{result.Amount}\t{result.note}\n");
            }
            return lastresult.ToString();
        }
    }
}
