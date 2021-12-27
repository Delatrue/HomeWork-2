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

    class BankAccount
    {
        private int _balance;
        private TypeAccount _typeAccount;
        static int _accountIdAuto = 0;
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
        public TypeAccount TypeAccount(int type)
        {
            _typeAccount = (TypeAccount)type;
            return _typeAccount;
        }
    }
}
