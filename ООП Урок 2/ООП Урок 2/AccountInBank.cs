using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Урок_2
{
    class AccountInBank
    {
        private int _balance;
        private TypeAccount _typeAccount;
        static int _accountIdAuto = 0;
        public int AccountId()
        {
            _accountIdAuto++;
            return _accountIdAuto;
        }
        public AccountInBank(int _balance)
        {
            AccountId();
            this._balance = _balance;
            Console.WriteLine($"{_accountIdAuto} {_balance}");
        }
        public AccountInBank(TypeAccount type)
        {
            AccountId();
            this._typeAccount = type;
            Console.WriteLine($"{_accountIdAuto} {_typeAccount}");
        }
        public AccountInBank(int _balance, TypeAccount type)
        {
            AccountId();
            this._balance = _balance;
            this._typeAccount = type;
            Console.WriteLine($"{_accountIdAuto} {_balance} {_typeAccount}");

        }
    }
}
