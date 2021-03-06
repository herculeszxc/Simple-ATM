using System;

namespace atmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;

            Console.WriteLine("ENTER PIN CODE: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (pin == code)
            {
                Console.Clear();
                mainmenu();
            }
            else
            {
                Console.WriteLine("INVALID PIN NUMBER");
            }

            Console.ReadKey();
        }
        // MAIN MENU
        public static void mainmenu()
        {

            Console.WriteLine("************************************");
            Console.WriteLine(">1. WITHDRAWAL");
            Console.WriteLine(">2. BALANCE INQUIRY");
            Console.WriteLine(">3. EXIT");
            Console.WriteLine("************************************");
            Console.WriteLine("CHOOSE 1 - 3 ");
            int x = Convert.ToInt32(Console.ReadLine());

            int savings = 100000;
            int checking = 500000;
            int credit = 200000;

            //int newSavings = savingsWithdraw(savings);

            if (x == 1)
            {
                //withdrawal
                Console.Clear();
                withdraw(savings, checking, credit);
            }
            else if (x == 2)
            {
                //balance inq
                Console.Clear();
                balanceinq(checking, credit, savings);
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.Clear();
            }

            // WITHDRAWAL
            static void withdraw(int savings, int checking, int credit)
            {
                Console.WriteLine("************************************");
                Console.WriteLine(">1. SAVING ACCOUNT");
                Console.WriteLine(">2. CHECKING ACCOUNT");
                Console.WriteLine(">3. CREDIT CARD ACCOUNT");
                Console.WriteLine("************************************");
                Console.WriteLine("CHOOSE 1 - 3 ");

                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    savingsWithdraw(savings);
                }
            }

            // WITHDRAW SAVINGS
            static int savingsWithdraw(int savings)
            {
                Console.Clear();
                Console.WriteLine("ENTER AMOUNT: ");
                int amount;
                amount = Convert.ToInt32(Console.ReadLine());

                savings = amount - savings;
                    
                if (amount <= savings)
                {
                    Console.Clear();
                    Console.WriteLine("WOULD YOU LIKE TO ANOTHER TRANSACT? Y/N");
                    String trans = Convert.ToString(Console.ReadLine());
                    if (trans == "Y" || trans == "y")
                    {
                        Console.Clear();
                        mainmenu();
                    }
                    else if (trans == "N" || trans == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("THANK YOU! COME AGAIN!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("INVALID TRANSACTION");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("INSUFFICIENT BALANCE");
                }
                return savings;
            }
            // BALANCE INQUIRY
            static void balanceinq(int savings, int checking, int credit)
            {
                Console.WriteLine("************************************");
                Console.WriteLine(">1. SAVING ACCOUNT");
                Console.WriteLine(">2. CHECKING ACCOUNT");
                Console.WriteLine(">3. CREDIT CARD ACCOUNT"); 
                Console.WriteLine("************************************");
                Console.WriteLine("CHOOSE 1 - 3 ");

                int y;
                y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Console.Clear();
                    Console.WriteLine("SAVINGS ACCOUNT BALANCE: " + savings);
                    Console.WriteLine("\nWOULD YOU LIKE TO ANOTHER TRANSACT? Y/N");
                    String trans = Convert.ToString(Console.ReadLine());
                    if (trans == "Y" || trans == "y")
                    {
                        Console.Clear();
                        mainmenu();
                    }
                    else if (trans == "N" || trans == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("THANK YOU! COME AGAIN!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("INVALID TRANSACTION");
                    }
                 }
                else
                {
                    Console.Clear();
                    Console.WriteLine("INVALID TRANSACTION");
                    mainmenu();
                }                
                
            }
        }   
    }
}
