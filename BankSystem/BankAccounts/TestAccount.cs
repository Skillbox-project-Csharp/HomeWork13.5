using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13._5.BankSystem.BankAccounts
{
    internal class TestAccount: BankAccount
    {

        public TestAccount(Guid id, double money) : base(id, money) { }
        public override bool AddMoney(double value)
        {
            if (value <= 0)
                return false;
            if (Money + value > 0)
            {
                _money += value;
                return true;
            }
            return false;
        }

        public override bool SubMoney(double value)
        {
            if (value <= 0)
                return false;
            if (Money - value >= 0)
            {
                _money -= value;
                return true;
            }
            return false;
        }

    }
}
