namespace Classes_and_Obejects
{
         class Program
    {
        static void Main(string[] args)
        {
            char doitAgn;
            do
            {
                int selectprogram;
                Console.WriteLine("Select A program to run.");
                Console.WriteLine("1.Bank Program. \n2.Student Program \n3.Five student program \n4.Online BookStore \n5.Credit Card \n6.Account Program");
                selectprogram = Convert.ToInt32(Console.ReadLine());
                switch (selectprogram)
                {
                    case 1:
                        BankAccount bankAccount = new BankAccount();
                        Console.WriteLine("--Assign Initial Values--");
                        bankAccount.initialValues();
                        char agn;
                        do
                        {

                            int num;
                            Console.WriteLine("Please Select Any Function.");
                            Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount. \nPress 3 for Balance Check");
                            num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 1:
                                    bankAccount.depositMoney();
                                    break;
                                case 2:
                                    bankAccount.withdrawMoney();
                                    break;
                                case 3:
                                    bankAccount.checkBal();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Selection!!!");
                                    break;
                            }
                            Console.WriteLine("\nDo you want to continue this program? (y/n)");
                            agn = Convert.ToChar(Console.ReadLine());

                        } while (agn == 'y');

                        // Console.ReadKey();
                     break;
                    case 2:
                        Student s= new Student();
                        s.studentData();
                        break;
                    case 3:
                        int rollno, sem;
                        string name, Class, branch;
                        StudentFiveMarks studentFiveMarks = new StudentFiveMarks();
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Roll No:");
                        rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Branch:");
                        branch = Console.ReadLine();
                        Console.WriteLine("Enter class:");
                        Class = Console.ReadLine();
                        Console.WriteLine("Enter sem:");
                        sem = Convert.ToInt32(Console.ReadLine());
                        studentFiveMarks.accept();
                        StudentFiveMarks studentFiveMarks1=new StudentFiveMarks(rollno,sem,name,Class,branch);
                          studentFiveMarks.displayResult();


                        break;
                    case 4:
                        onlineBookstore onlineBookstore = new onlineBookstore();
                        onlineBookstore.bookStore();
                        onlineBookstore.Display();
                        break;
                    case 5:
                        Creditcard creditcard = new Creditcard();
                        Console.WriteLine("Enter Monthly Amount:");
                        long monthlyAmt=Convert.ToInt32(Console.ReadLine());
                        creditcard.monthly(monthlyAmt);
                        break;
                    case 6:
                        Accounts accounts = new Accounts(); 
                        string customerName, accountType, transactionType, accountNo;
                        long bal;
                        Console.WriteLine("Enter Customer Name:");
                        customerName=Console.ReadLine();
                        Console.WriteLine("Enter Account No:");
                        accountNo=Console.ReadLine();
                        Console.WriteLine("Select Account Type Saving/Current:");
                        accountType=Console.ReadLine();
                        Console.WriteLine("Add Initial Amount:");
                        bal=Convert.ToInt32(Console.ReadLine());
                        accounts.accept(accountNo,customerName,accountType,bal);
                        char agnn;
                        do
                        {

                            int num;
                            Console.WriteLine("Please Select Any Function.");
                            Console.WriteLine("Select a function:\n1.Withdraw \n2.Deposit \n3.Display details");
                            num = Convert.ToInt32(Console.ReadLine());
                            switch (num) {
                                case 1:
                                    Console.WriteLine("Enter Amount to withdraw:");
                                    int withdraw=Convert.ToInt32(Console.ReadLine());
                                    accounts.withdrawAmount(withdraw);                                    
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Amount to deposit");
                                    int deposit = Convert.ToInt32(Console.ReadLine());
                                    accounts.depositAmount(deposit);
                                    break;
                                case 3:
                                    Console.WriteLine("Display Details:");
                                    accounts.show();
                                    break;

                                }
                            Console.WriteLine("\nDo you want to continue? (y/n)");
                            agnn = Convert.ToChar(Console.ReadLine());

                        } while (agnn != 'n');

                        break;
                }
                Console.WriteLine("\nDo select program? (y/n)");
                doitAgn = Convert.ToChar(Console.ReadLine());
            } while (doitAgn == 'y');
         }
    }
}