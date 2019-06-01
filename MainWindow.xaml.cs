using System;
using System.Collections.Generic;
using System.Collections;
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

namespace AlpaATMGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public int keypadinput { get; set; }
        public List<int> accountNumber = new List<int>();
        public bool authenticateUser { get; set; }
        public double initialaccountBalance {get;set;}

        public MainWindow()
        {
            InitializeComponent();
            Screen.Text = " Please enter your 4 digit account number by pressing on the key pad and then press enter \n press 0 to restart \n Examples of matching account numbers in the bank database are \n 1234 \n 3456 \n 6735 \n 7869 \n ";

        }



        private void ButtonWithdrawl_Click(object sender, RoutedEventArgs e)
        {
            if ((this.authenticateUser))
            {
                MessageBox.Show(" Cash has been withdrawn");

                Screen.Text = "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ";
            }
        }

        private void ButtonDeposit_Click(object sender, RoutedEventArgs e)
        {
            if ((this.authenticateUser))
            {
                MessageBox.Show("Envelope has been received");
                Screen.Text = "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ";

            }
        }
        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 1;
            accountNumber.Add(keypadinput);

        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 2;
            accountNumber.Add(keypadinput);

        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 3;
            accountNumber.Add(keypadinput);

        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 4;
            accountNumber.Add(keypadinput);

            if (Screen.Text == "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ")
                this.Close();
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 5;
            accountNumber.Add(keypadinput);

        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 6;
            accountNumber.Add(keypadinput);

        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 7;
            accountNumber.Add(keypadinput);

        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 8;
            accountNumber.Add(keypadinput);

        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            this.keypadinput = 9;
            accountNumber.Add(keypadinput);

        }

        private void ButtonTen_Click(object sender, RoutedEventArgs e)
        {
            if (this.authenticateUser)
                Screen.Text = "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ";
            else
                accountNumber.Clear();
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            int transactionResult = 0 ;

            string displayscreen = Screen.Text;

            if (!(this.authenticateUser))
                 executeauthenticateUser();
            else if ((this.authenticateUser))
            {
                ATMSystem Customer = new ATMSystem();      // new object every time you press Enter

                transactionResult= Customer.run(this.keypadinput, ref displayscreen, this.initialaccountBalance);

                Screen.Text = displayscreen;

            }

            if (transactionResult == 1)
                ButtonWithdrawl_Click(sender,e);
            else if (transactionResult == 3)
                ButtonDeposit_Click(sender, e);

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public int executeauthenticateUser()
        {
            bool areEqual = false;
            string arrayAccountNumber = "";
            arrayAccountNumber = $"{accountNumber[0]}" + $"{accountNumber[1]}" + $"{accountNumber[2]}" + $"{accountNumber[3]}";

          this.initialaccountBalance=BankDatabase.demo(arrayAccountNumber, ref areEqual);

            if (areEqual)
            {
                this.authenticateUser = true;
                MessageBox.Show("Account number matches");
                accountNumber.Clear();
                Screen.Text = "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ";
            }
            else
                MessageBox.Show("Account number does not match");

            return 0;
        }

        private void CustomGUI_Click(object sender, RoutedEventArgs e)
        {
            CustomGUI launchCustomGUI = new CustomGUI();
            launchCustomGUI.Show();
        }



    } // partial MainWindow Class
    public class BankDatabase
        {

            public BankDatabase()
            {
       
            }

        public static double demo(string compareAccountNumber, ref bool areEqual)
         {
            double initialaccountBalanceDemo = 0;
            //Create a hash table 
            Hashtable BankAccountDatabaseHashTable = new Hashtable();

            using (System.IO.StreamReader rwequities = System.IO.File.OpenText("BankDatabase.txt"))
                {
                    string readLine;
                    while ((readLine = rwequities.ReadLine()) != null)  // reads one line at a time
                    {
                        char delimiter = ',';
                        string[] parseReadLine = readLine.Split(delimiter);
                        BankAccountDatabaseHashTable.Add( parseReadLine[0], double.Parse(parseReadLine[1]) );
                    }
                }

            IDictionaryEnumerator BankAccountDatabaseHashTableIterator = BankAccountDatabaseHashTable.GetEnumerator();
            while( BankAccountDatabaseHashTableIterator.MoveNext() && areEqual!=true)
            {
                string compare = BankAccountDatabaseHashTableIterator.Key.ToString();
                if (compare == compareAccountNumber)
                {
                    initialaccountBalanceDemo= double.Parse(BankAccountDatabaseHashTable[compareAccountNumber].ToString());
                    areEqual = true;
                }
    
            }

            BankAccountDatabaseHashTable.Clear();

            return initialaccountBalanceDemo;
            } // public static int demo

        }// public class database


} // name space
