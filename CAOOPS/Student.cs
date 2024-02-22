using CAOOPS;
using System.Transactions;

namespace CAOOPS
{

    class studentDetails
    {
        String stName;
        public int subjects;
        

        public void getDetails()
        {
            
            Console.WriteLine("Enter Student name");
            stName = Console.ReadLine();
            Console.WriteLine("Enter no of subjects");
            subjects=Convert.ToInt32(Console.ReadLine());
        }

        public float getAverage()
        {
            int res = 0;
            for (int i = 1;i<=subjects;i++) 
            {
                Console.Write("Enter Sub-" + i + ":");
                int subi=int.Parse(Console.ReadLine());
                
                res = res + subi;
            }
            return res/subjects;
        }

        public void checkAverage(float a)
        {
            if (a > 35 && a < 75)
            {
                Console.WriteLine("Result is Pass");
            }
            else if (a >= 75)
            {
                Console.WriteLine("Result is Distinction");
            }
            else 
            {
                Console.WriteLine("Result is Fail");
            }
            }
           
        }
    }
    class Student
    {
        static void Main(string[] args)
        {
            studentDetails sd = new studentDetails();
            sd.getDetails();
            float avg = sd.getAverage();
            Console.WriteLine("Average marks are " + avg );
            sd.checkAverage(avg);
       
            
        
        }
    }


