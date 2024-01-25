using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    public class Transcations
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string note { get; }
        public Transcations(decimal amount,DateTime date,string remarks)
        {
            this.Amount += amount;
            Date = date;
            note = remarks.ToUpper();
        }

    }
}
