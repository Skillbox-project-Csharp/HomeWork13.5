using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13._5.BankSystem.BankAccounts
{
    internal class NoDepositAccount : BankAccount, IEquatable<BankAccount>
    {
        public override double Rub => _rub;

        public override Guid Id => _id;

        public NoDepositAccount()
        {
            _rub = 0;
            _id = Guid.NewGuid();
        }
        public override bool AddMoney(double value)
        {
            if (value <= 0)
                return false;
            if (Rub + value > 0)
            {
                _rub += value;
                return true;
            }
            return false;
        }

        public override bool SubMoney(double value)
        {
            if (value <= 0)
                return false;
            if (Rub - value >= 0)
            {
                _rub -= value;
                return true;
            }
            return false;
        }

        public bool Equals(BankAccount other)
        {
            return Id == other.Id ? true : false;
        }
    }
}
