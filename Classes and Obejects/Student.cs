namespace Classes_and_Obejects
{
    class Student
    {
        string stdName;
        int rollNo = 0, engMarks = 0, mathMarks = 0, scienceMarks = 0, TotalMarks = 0;
        double Avg=0;

        public void studentData()
        {
            Console.WriteLine("Enter Student Name:");
            stdName = Console.ReadLine();
            Console.WriteLine("Enter Roll No. of the Student:");
            rollNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks");
            engMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks");
            mathMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Science Marks");
            scienceMarks = Convert.ToInt32(Console.ReadLine());
            avgMarks();
        }

        private void avgMarks()
        {
            Console.WriteLine("Name of the student:"+stdName);
            TotalMarks+=engMarks+mathMarks+scienceMarks;
            Console.WriteLine("Total Marks is:"+TotalMarks);
            Avg =TotalMarks / 3;
            Console.WriteLine("Percentage is:"+Avg);

        }
    }
}