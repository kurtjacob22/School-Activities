using System;

namespace ThirdQuarterExamination_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PIN = new string[] {
                "7630","6723","1991","9210", "1620"
            };

            string[] transactions = new string[] {
                "[1] Deposit",
                "[2] Withdraw",
                "[3] Check Current Balance",
                "[4] Exit",
            };


            

            string titleHead = @"
         _ .-') _               _   .-')          .-. .-')     ('-.         .-') _ .-. .-')   
        ( (  OO) )             ( '.( OO )_        \  ( OO )   ( OO ).-.    ( OO ) )\  ( OO )  
     ,--.\     .'_  .-'),-----. ,--.   ,--.)       ;-----.\   / . --. /,--./ ,--,' ,--. ,--.  
 .-')| ,|,`'--..._)( OO'  .-.  '|   `.'   |        | .-.  |   | \-.  \ |   \ |  |\ |  .'   /  
( OO |(_||  |  \  '/   |  | |  ||         |        | '-' /_).-'-'  |  ||    \|  | )|      /,  
| `-'|  ||  |   ' |\_) |  |\|  ||  |'.'|  |        | .-. `.  \| |_.'  ||  .     |/ |     ' _) 
,--. |  ||  |   / :  \ |  | |  ||  |   |  |        | |  \  |  |  .-.  ||  |\    |  |  .   \   
|  '-'  /|  '--'  /   `'  '-'  '|  |   |  |        | '--'  /  |  | |  ||  | \   |  |  |\   \  
 `-----' `-------'      `-----' `--'   `--'        `------'   `--' `--'`--'  `--'  `--' '--'  
";

            string seperator = "+-------------------------------------------------------------------------------------------+";
            //string seperator = "+----------------------------Do you want to transact again ?--------------------------------+";
            string ansOption;

            
            double defBal = 50000;
            double depositAmount,withdrawAmount;
            int increment = 0;
            int transactionOrders = 100;

            string keyValidator;

            //Pin numberinput
            Console.WriteLine("\nHi, Welcome to JDOM's Bank, one of the best banks in the world");
            Console.Write("\n\tPlease Input your Pin number: ");
            string ansPin = Console.ReadLine();

            while (true) {
                if (ansPin == PIN[0]) {
                    break;

                } else if (ansPin == PIN[1]) {
                    break;
                }
                else if (ansPin == PIN[3])
                {
                    break;
                }
                else if (ansPin == PIN[4])
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Pin Number ");
                    Console.Write("Please Input your Pin number again: ");
                    ansPin = Console.ReadLine();

                }
            }

            Console.Clear();


            //Banner
            Console.WriteLine(seperator);
            Console.WriteLine(titleHead);
            Console.WriteLine(seperator);

            //Live Date and Time
            Console.WriteLine("\nToday is " + DateTime.Now);


            Console.WriteLine("\n\tPress any key to continue ");
            Console.ReadKey();
            Console.Clear();
//do this
          

            do {

                // transactions
                Console.WriteLine(seperator);
                Console.WriteLine("+--------------------------------Please pick your transaction--------------------------------+");
                Console.WriteLine(seperator + "\n");

                for (int x = 0; x < transactions.Length; x++)
                {
                    Console.WriteLine("\t" + transactions[x]);
                }

                Console.Write("Enter number here: ");
                ansOption = Console.ReadLine();

                string optionMenuAnswer;

                while (true)
                {
                    if (ansOption == "1")
                    {
                        //Deposit

                        Console.WriteLine("\n" + seperator);
                        Console.WriteLine("+-----------------------------------JDOM Bank Deposit---------------------------------------+");
                        Console.WriteLine(seperator);
                        Console.WriteLine("Enter Amount to be deposited:");
                        Console.Write("Php");
                        depositAmount = Convert.ToDouble(Console.ReadLine());
                        defBal += depositAmount;

                        Console.Clear();
                        Console.WriteLine("You have Deposited PHP" + depositAmount);
                        Console.WriteLine("your total balance is: PHP" + defBal);

                        Console.WriteLine(seperator);

                        //Copy this
                        Console.WriteLine("+----------------------------Do you want to transact again ?--------------------------------+");
                        Console.WriteLine("+-------------------------Press Y to return to menu, N to quit------------------------------+");
                        optionMenuAnswer = Console.ReadLine();

                        while (true)
                        {
                            if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                            {

                                while (true)
                                {
                                    if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                                    {
                                        Main(null);
                                        
                                    }
                                    else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                                    {
                                        break;
                                    }
                                }

                                //until here
                                break;

                            }
                            else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                            {
                                break;
                            }
                        }

                        //until here
                        break;

                    }
                    else if (ansOption == "2")
                    {
                        //Withdraw
                        Console.WriteLine("\n" + seperator);
                        Console.WriteLine("+-----------------------------------JDOM Bank Withdraw--------------------------------------+");
                        Console.WriteLine(seperator);
                        Console.WriteLine("Enter Amount:");
                        Console.Write("Php");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        while (true) {
                            if (withdrawAmount > defBal) { 
                                Console.WriteLine("\n\tYour balance is not enough");
                                Console.Write("\tEnter Amount: PHP");
                                withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            }
                            else {
                                break;
                            }
                        }


                        defBal -= withdrawAmount;

                        Console.Clear();
                        Console.WriteLine("You have Deposited PHP" + withdrawAmount);
                        Console.WriteLine("your total balance is: PHP" + defBal);

                        Console.WriteLine(seperator);

                        //Copy this
                        Console.WriteLine("+----------------------------Do you want to transact again ?--------------------------------+");
                        Console.WriteLine("+-------------------------Press Y to return to menu, N to quit------------------------------+");
                        optionMenuAnswer = Console.ReadLine();

                        while (true)
                        {
                            if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                            {

                                while (true)
                                {
                                    if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                                    {
                                        Main(null);
                                    }
                                    else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                                    {
                                        break;
                                    }
                                }

                                //until here
                                break;

                            }
                            else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                            {
                                break;
                            }
                        }

                        //until here

                        break;

                    }
                    else if (ansOption == "3")
                    {
                        //Check Current Balance
                        Console.WriteLine("\n" + seperator);
                        Console.WriteLine("+------------------------------Your current account Balance---------------------------------+");
                        Console.WriteLine(seperator);
                        Console.WriteLine("your total balance is: PHP" + defBal);

                        //Copy this
                        Console.WriteLine("\n+----------------------------Do you want to transact again ?--------------------------------+");
                        Console.WriteLine("+-------------------------Press Y to return to menu, N to quit------------------------------+");
                        optionMenuAnswer = Console.ReadLine();

                        while (true)
                        {
                            if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                            {

                                while (true)
                                {
                                    if (optionMenuAnswer == "Y" || optionMenuAnswer == "y")
                                    {
                                        Main(null);

                                    }
                                    else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                                    {
                                        break;
                                    }
                                }

                                //until here
                                break;

                            }
                            else if (optionMenuAnswer == "N" || optionMenuAnswer == "n")
                            {
                                break;
                            }
                        }

                        //until here
                        break;

                    }
                    else if (ansOption == "4")
                    {


                        Console.WriteLine("\n" + seperator);
                        Console.WriteLine("+-----------------Thank you for your transaction, we are happy to serve you!----------------+");
                        //Environment.Exit(0);
                        Console.WriteLine(seperator);

                        Console.WriteLine("Press any key to exit");
                        keyValidator = Console.ReadLine();
                        if (keyValidator != "" || keyValidator =="")
                        {
                            Environment.Exit(0);
                        }
                        else { }

                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a transaction ");
                        Console.Write("\tEnter number here: ");
                        ansOption = Console.ReadLine();
                    }
                    
                }
                increment++;
            } while (increment != transactionOrders);

            



            Console.ReadKey();

            /*
                3rd Quarter Exam,
                Kurt Jacob E. Urquico,
                Student no : 3180105,
                ICT11-A
             */
        }
    }
}