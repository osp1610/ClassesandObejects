namespace Classes_and_Obejects
{
    class StudentFiveMarks
    {

        int rollno, sem;
        string name, Class, branch;
        int[] marks = new int[5];
        int avg = 0,sum=0;
        bool isPass=true;
        public StudentFiveMarks()
        {

        }
        public StudentFiveMarks(int rollno, int sem, string name, string Class, string branch)
        {
            this.rollno = rollno;
            this.sem = sem;
            this.name = name;
            Class = Class;
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
                sum = sum + marks[i];
            }
            avg = sum / 5;
            Console.WriteLine(avg);

        }


        public void displayResult()
        {
         

                foreach (int mark in marks)
                {
                    if (mark < 35 && avg<50)
                    {
                        isPass = false;
                        break;
                    }

                }
            
            if (isPass == false)
            {
                Console.WriteLine("Your Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }
    }
}