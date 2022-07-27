namespace Classes_and_Obejects
{
    class BankAccount
    {
        string NameOfDepositor,AccountType;
        long AccountNo, AccountBal = 0, deposit = 0, withdraw = 0;
        
        public void initialValues()
        {
            Console.WriteLine("Enter Name of the depositor :");
            NameOfDepositor = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Type :");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter Deposit Amount :");
            deposit = Convert.ToInt64(Console.ReadLine());
            AccountBal = AccountBal + deposit;
            

        }

        public void depositMoney()
        {
            Console.WriteLine("Enter Deposit Amount :");
            deposit = Convert.ToInt64(Console.ReadLine());
            AccountBal = AccountBal + deposit;
        }

        public void withdrawMoney()
        {
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToInt64(Console.ReadLine());
            if (withdraw > AccountBal)
            {
                Console.WriteLine("Enter Valid Amount");
                withdraw = Convert.ToInt64(Console.ReadLine());
                AccBalFun();

            }
            else
            {
                AccBalFun();
            }
            
        }
        public void AccBalFun()
        {
            AccountBal = AccountBal - withdraw;

        }
        public void checkBal()
        {
            Console.WriteLine("Depositer Name:" + NameOfDepositor + "\n Account Balance:" + AccountBal);
        }

        public void Display()
        {
            Console.WriteLine("Depositor Name:"+NameOfDepositor+ "\nAccount Number:"+AccountNo+"\nAccount Type"+AccountType+"\nAccount Balance"+AccountBal);
        }
    }
}