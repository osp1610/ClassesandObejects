namespace Classes_and_Obejects
{
    class Creditcard
    {
        int month = 0;
        double debtAmt = 1000;
       public void monthly(long monthlyAmt)
        {
            //Console.WriteLine("Month:" +month + " Balance:" + debtAmt + " Total Payments:" +monthlyAmt );
            //debtAmt = debtAmt * 1.015;
            //debtAmt= debtAmt-monthlyAmt;

            while (debtAmt > monthlyAmt)
            {
                debtAmt = debtAmt * 1.015;
                debtAmt= debtAmt - monthlyAmt;
                Console.WriteLine("Month:"+(month=month+1)+" Balance:"+debtAmt+" Total Payments:"+(monthlyAmt*month));
            }
            Console.WriteLine("\nBalance:" + debtAmt + " Total Payed:" + (monthlyAmt * month - debtAmt));
        }
    }
}