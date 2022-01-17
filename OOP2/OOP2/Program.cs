using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.IdAccount();
            account1.Balance = 1000;
            account1.TypeAccount = TypeAccount.Current;
            account1.Print();

            BankAccount account2 = new BankAccount();
            account2.IdAccount();
            account2.Balance = 2000;
            account2.TypeAccount = TypeAccount.Current;
            account2.Print();

            account1.GetMoneyFromAccount(500);
            account1.PutMoneyToAccount(600);

            account1.TransferTransaction(account2, 500);
            account1.Print();
            account2.Print();

            account1.Reverse("swordDROWS");
        }
    }
}
