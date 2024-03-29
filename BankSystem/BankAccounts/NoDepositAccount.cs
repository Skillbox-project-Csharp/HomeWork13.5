﻿using HomeWork13._5.BankSystem.BankAccounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13._5.BankSystem.BankAccounts
{
    internal class NoDepositAccount : BankAccount, IReplenishment<BankAccount>, IMoneyTransfer<BankAccount>
    {
        //костыль
        public override Type TypeAccount { get; set; } = typeof(NoDepositAccount);
        public NoDepositAccount(Guid id, double money) : base(id, money) { }
        public NoDepositAccount()
            : base(Guid.NewGuid(), 0) { }
        public override bool AddMoney(double value)
        {
            return base.AddMoney(value);
        }

        public override bool SubMoney(double value)
        {
            return base.SubMoney(value);
        }

        public override BankAccount Replenishment(double value)
        {
            this.AddMoney(value);
            return new BankAccount(this.Id, this.Money);
        }

        public override void MoneyTransferCov(Client recipient, BankAccount recipientAccount, double value)
        {
            int indexSenderAccount = recipient.BankAccounts.IndexOf(recipientAccount);
            if (indexSenderAccount != -1)
                if (!recipientAccount.Equals(this))
                    if (this.SubMoney(value))
                    {
                        if (recipient.BankAccounts[indexSenderAccount].AddMoney(value)) { }
                        else
                        {
                            this.AddMoney(value);

                        }
                    }
        }
    }
}
