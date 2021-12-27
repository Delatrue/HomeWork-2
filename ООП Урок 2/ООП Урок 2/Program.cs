using System;

namespace ООП_Урок_2
{    
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance(1000);
            account.TypeAccount(0);
                       
            void PrintBA()
            {
                Console.WriteLine($"{account.AccountId()} {account.Balance(1000)} {account.TypeAccount(0)}");
            }
            PrintBA();


            AccountInBank account2 = new AccountInBank(1500, 0); // Не успел разобраться, почему перечисляемое "0" - работает на выходе тип счета "Current"
                                                                 // А, "1" и "2" - нет.
        }
    }
}
