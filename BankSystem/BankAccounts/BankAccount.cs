using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13._5.BankSystem.BankAccounts
{
    internal abstract class BankAccount
    {
        protected double _rub;
        protected Guid _id;
        abstract public double  Rub { get; }
        abstract public Guid Id { get; }
        abstract public bool AddMoney(double value);
        abstract public bool SubMoney(double value);
    }
}
