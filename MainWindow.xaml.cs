using HomeWork13._5.BankSystem;
using HomeWork13._5.BankSystem.BankAccounts;
using HomeWork13._5.BankSystem.BankAccounts.Interfaces;
using HomeWork13._5.BankSystem.BankClients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork13._5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Client> BankClients { get; set; }
        internal Client SelectedBankClient1 { get; set; }
        internal Client SelectedBankClient2 { get; set; }
        internal BankAccount SelectedBankAccount1 { get; set; }
        internal BankAccount SelectedBankAccount2 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            BankClients = new ObservableCollection<Client>();
            for (int i = 0; i < 25; i++)
            {
                BankClient client = new BankClient($"Name{i}", $"SurName{i}", $"Patronymic{i}");
                Bank.OpenNewBankAccount(client, new DepositAccount(Guid.NewGuid(), i));
                BankClients.Add(client);

            }
            ListBoxDataClients1.ItemsSource = BankClients;
            ListBoxDataClients2.ItemsSource = BankClients;
        }

        private void ListBoxDataClients1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ListBoxDataClients1.SelectedItem is BankClient client)
            {
                SelectedBankClient1 = client;
                ListBoxClientBankAccounts1.ItemsSource = client.BankAccounts;
            }

        }

        private void ListBoxDataClients2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxDataClients2.SelectedItem is BankClient client)
            {
                SelectedBankClient2 = client;
                ListBoxClientBankAccounts2.ItemsSource = client.BankAccounts;
            }
        }

        private void ListBoxClientBankAccounts1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxClientBankAccounts1.SelectedItem is BankAccount bankAccount)
                SelectedBankAccount1 = bankAccount;
        }

        private void ListBoxClientBankAccounts2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxClientBankAccounts2.SelectedItem is BankAccount bankAccount)
                SelectedBankAccount2 = bankAccount;
        }

        private void ButtonCloseAccount_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedBankClient1 != null && SelectedBankAccount1 != null)
                    Bank.CloseBankAccount(SelectedBankClient1, SelectedBankAccount1);
        }

        private void ButtonOpenAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonReplenishmentAccount_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
