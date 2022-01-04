using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Урок_2
{
    enum TypeAccount
    {
        Current,
        Deposit,
        Foreign
    }
    internal class BankAccount
    {
        private int _idAccount;
        private decimal _balance;
        private TypeAccount _typeAccount;
        private static int _idAccountGenerate = 0;

        public int IdAccount()
        {
            this._idAccount = ++_idAccountGenerate;
            return _idAccountGenerate;
        }
        public decimal Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        public TypeAccount TypeAccount
        {
            get
            {
                return this._typeAccount;
            }
            set
            {
                this._typeAccount = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"{_idAccount} {_balance} {_typeAccount}");
        }

        public decimal GetMoneyFromAccount(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Operation error");
                return -1;
            }
            else if (_balance - value > 0)
            {
                _balance = _balance - value;
                Console.WriteLine($"Остаток на счете {_balance}");
                return _balance;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                return -1;
            }
        }

        public decimal PutMoneyToAccount(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Operation error");
                return -1;
            }
            else
            {
                _balance = _balance + value;
                Console.WriteLine($"Остаток на счете {_balance}");
                return _balance;
            }
        }
    }
}
