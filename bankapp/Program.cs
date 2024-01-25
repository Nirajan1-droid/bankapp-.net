// See https://aka.ms/new-console-template for more information
using Bankapp;

Console.WriteLine("Hello, World!");

var newaccount = new BankAccount("Nirajan", -1000,"reamkrs while depositing which is i t hink unnecessary");

Console.WriteLine($"Bank account created for {newaccount.Name} for {newaccount.Amount} ");

newaccount.WithdrawDeposit(-500, DateTime.Now, "laptop ssd");

Console.WriteLine(newaccount.HistoryTranscations());