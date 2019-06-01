using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpaATMGUI
{
    public class ATMSystem
    {

        public ATMSystem()
        {
 
        }


        public static int run(int keypadinput, ref string displayscreen,double initialaccountBalance)
        {
            int transactionResult = 0;

            int debitAmount=0;
            int creditAmount=0;
            double Newbalance=0;

            switch (keypadinput)
            {
                case 0:
                    break;
                case 1:  // withdrawal menu
                    {
                        if (displayscreen != "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            displayscreen = "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ";
                         else if(displayscreen == "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            debitAmount = 20;
                        else if (displayscreen=="Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                        creditAmount = 20;
                   }
                    break;
               case 2: // view balance menu
                    {
                        if (displayscreen == "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            debitAmount = 40;
                        else if (displayscreen == "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                            creditAmount = 40;
                        else if (displayscreen == "Main Menu \n \t 1 - Withdraw cash \n \t 2 - View my balance \n \t 3 - Deposit funds \n \t 4 - Exit \n Enter a choice: ")
                            displayscreen = $"Initial checking account balance prior to any current transaction is ${initialaccountBalance}, please press 0 to continue";
                    }
                    break;
                case 3: //  deposit menu
                    {
                        if (displayscreen == "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            debitAmount = 60;
                        else if (displayscreen != "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                            displayscreen = "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ";
                        else if (displayscreen == "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                            creditAmount = 60;
                    }
                    break;
                case 4:
                    {
                        if (displayscreen == "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            debitAmount = 100;
                        else if (displayscreen == "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                            creditAmount = 100;
                    }
                    break;
                case 5:
                    {
                        if (displayscreen == "Withdrawal Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a withdrawal amount: ")
                            debitAmount = 200;
                        else if (displayscreen == "Deposit Menu \n\t1 - $20\t\t2 - $40\n\t3 - $60\t\t4 - $100\n\t5 - $200\t\t0 - Cancel transaction\n Choose a deposit amount: ")
                            creditAmount = 200;
                    }
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            } // end of the switch statement

            try
            {
                if (debitAmount != 0)
                {
                    if (debitAmount > initialaccountBalance)
                        throw new NegativeBankBalanceException();
                    else
                    {
                        Newbalance = initialaccountBalance - debitAmount;
                        transactionResult = 1; // debit transaction
                    }
                }
                else if (creditAmount != 0)
                {
                    Newbalance = initialaccountBalance + creditAmount;
                    transactionResult = 3; // credit transaction
                }
            }
            catch (NegativeBankBalanceException)
            {
                displayscreen = " Cannot exceed checking balance amount, please press 0 to continue";
            }

   

            return transactionResult;
        } // end of the run statement

    } // ATM system


    public class NegativeBankBalanceException: Exception
    {
        public NegativeBankBalanceException():base("Cannot exceed checking balance amount")
        {

        }

    }



}



