namespace Classes_and_Obejects
{
    class Accounts
    {
        long  accountBal = 0, deposit = 0, withdraw = 0;
        string customerName, accountType, transactionType, accountNo;


        public void accept(string accNo,string custName,string accType,long bal)
        {
            accountBal = bal;
            customerName = custName;
            accountType = accType;
            accountNo = accNo;

        }
        public void depositAmount(int depositt)
        {
            accountBal = accountBal + depositt;
            Console.WriteLine("Balance:" + accountBal);
        }
        public void withdrawAmount(int withdraw)
        {
            accountBal=accountBal-withdraw;
            Console.WriteLine("Balance:" + accountBal);
        }
        public void show()
        {
            Console.WriteLine("Customer Name:" + customerName + "\nAccount No:" + accountNo + "\nAccount Type:" + accountType + "\nAccount Balance:" + accountBal);
        }
    }
}