namespace Classes_and_Obejects
{
    class onlineBookstore
    {
        int bookNo, bookQty, bookPrice = 0, totalAmt = 0;
        String bookName, bookTitle, bookAuthor;
        public void bookStore()
        {
            Console.WriteLine("Enter a book no.:");
            bookNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a book name:");
            bookName=Console.ReadLine();
            Console.WriteLine("Enter a book title:");
            bookTitle=Console.ReadLine();
            Console.WriteLine("Enter a book author:");
            bookAuthor=Console.ReadLine();
            Console.WriteLine("Enter a book quantity:");
            bookQty=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a book price:");
            bookPrice = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("--Final Bill Amount--");
            totalAmt = totalAmt + (bookQty * bookPrice);
            Console.WriteLine("Total Bill Amount for "+bookQty+" books is:"+totalAmt);
        }
    }
}