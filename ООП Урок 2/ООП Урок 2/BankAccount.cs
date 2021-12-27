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
        private int _balance;
        private TypeAccount _typeAccount;
        public static int _accountIdAuto = 0;
        public int AccountId()
        {
            _accountIdAuto++;
            return _accountIdAuto;
        }
        public int Balance(int value)
        {
            _balance = value;
            return _balance;
        }
        public TypeAccount TypeAccount(TypeAccount type)
        {
            _typeAccount = (TypeAccount)type;
            return _typeAccount;
        }

        // Снять деньги
        public int GetMoney(int value)
        {
            if(value <= 0)
            {
                Console.WriteLine("Invalide sum");
                return -1;
            }
            else if(_balance - value > 0)
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

        // Положить деньги
        public int PutMoney(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Invalide sum");
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
