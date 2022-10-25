using HomeWork13._5.BankSystem;
using HomeWork13._5.BankSystem.BankAccounts;
using HomeWork13._5.BankSystem.BankAccounts.Interfaces;
using HomeWork13._5.BankSystem.BankClients;
using System;
using System.Collections.Generic;
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
         static void Prints(Client bankClient)
        {
            Debug.WriteLine(bankClient.Name);
            Debug.WriteLine(bankClient.SurName);
            Debug.WriteLine(bankClient.Patronymic);
            foreach(var account in bankClient.BankAccounts)
            {
                Debug.WriteLine("\t" + account.GetType().Name);
                Debug.WriteLine("\t"+account.Id.ToString());
                Debug.WriteLine("\t" + account.Money);
                Debug.WriteLine("---------------------------------------------------------");
            }
            Debug.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
