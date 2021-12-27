using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Урок_2
{
    internal class BankAccountProp
    {
        private int _balance;
        private TypeAccount _typeAccount;
        public int AccountId()
        {
            BankAccount._accountIdAuto++;
            return BankAccount._accountIdAuto;
        }

        public int Balance
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
    }
}
