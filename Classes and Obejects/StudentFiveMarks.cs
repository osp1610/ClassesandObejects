namespace Classes_and_Obejects
{
    class StudentFiveMarks
    {

        int rollno, sem;
        string name, Class, branch;
        int[] marks = new int[5];
        int avg = 0,sum=0;
        public StudentFiveMarks()
        {

        }
        public StudentFiveMarks(int rollno, int sem, string name, string Class, string branch)
        {
            this.rollno = rollno;
            this.sem = sem;
            this.name = name;
            this.Class = Class;
            this.branch = branch;
            Console.WriteLine("Name of the students:" + name);
            Console.WriteLine("Roll No:" + rollno);
            Console.WriteLine("Class:" + Class);
            Console.WriteLine("Branch:" + branch);
            Console.WriteLine("Semester:" + sem);
            Console.WriteLine("\nResult");
        }

        public void accept()
        {
            Console.WriteLine("Enter marks of five subjects");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        public void displayResult()
        {
            bool isPass = true;
            foreach (int mark in marks)
            {
                sum += mark;
                if (mark < 35)
                {
                    isPass = false;
                    break;
                }
            }

            avg = sum / 5;

            Console.WriteLine("Average Marks: " + avg);
            if (avg > 50 && isPass)
            {
                Console.WriteLine("You're Pass");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}