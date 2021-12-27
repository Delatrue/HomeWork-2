using System;

namespace ООП_Урок_2
{    
    public class Program
    {
        static void Main(string[] args)
        {
            //методы, класс BankAccount
            //метод генерации Id реализован в классе BankAccount и используется в других классах
            BankAccount account = new BankAccount();
                                  
            void PrintBA()
            {
                Console.WriteLine($"{account.AccountId()} {account.Balance(1000)} {account.TypeAccount(TypeAccount.Current)}");
            }
            PrintBA();

            //конструкторы, класс AccountInBank
            AccountInBank account2 = new AccountInBank(1500, TypeAccount.Foreign);
            AccountInBank account3 = new AccountInBank(1800, TypeAccount.Current);

            //свойства, класс BankAccountProp
            BankAccountProp account4 = new BankAccountProp();
            account4.AccountId();
            account4.Balance = 2300;
            account4.TypeAccount = TypeAccount.Current;
            Console.WriteLine($"{BankAccount._accountIdAuto} {account4.Balance} {account4.TypeAccount}");

            account.GetMoney(100);
            account.PutMoney(500);
            
        }
    }
}
