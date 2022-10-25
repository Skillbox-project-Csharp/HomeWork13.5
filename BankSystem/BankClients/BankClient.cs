using HomeWork13._5.BankSystem.BankAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13._5.BankSystem.BankClients
{
    internal class BankClient : Client
    {
        public BankClient()
        {
            _Id = Guid.NewGuid();
            _bankAccounts = new List<BankAccount>();
            Name = string.Empty;
            SurName = string.Empty;
            Patronymic = string.Empty;
        }
        public BankClient(string name, string surName, string patronymic, Guid id, List<BankAccount> bankAccounts)
        {
            _Id = id;
            _bankAccounts = bankAccounts;
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
        }

        public BankClient(string name, string surName, string patronymic)
            : this(name, surName, patronymic, Guid.NewGuid(), new List<BankAccount>()) { }


        public override Guid Id => _Id;
        public override List<BankAccount> BankAccounts => _bankAccounts;
        public override string Name { get => _name; set => _name = value; }
        public override string SurName { get => _surName; set => _surName = value; }
        public override string Patronymic { get => _patronymic; set => _patronymic = value; }
    }
}
