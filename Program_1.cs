using System;

namespace Property
{
    public class Date
    {
<<<<<<< user2
        private int month = 11;
=======
        private int month = 5;
>>>>>>> master

        public int Month
        {
            get { return month; }
            set { if ((value > 0) && (value < 13)) month = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Console.WriteLine("Default month : {0}\n", d1.Month);

            while (true)
            {
                Console.Write("Enter month : ");
                int inputMonth = int.Parse(Console.ReadLine());
                if (inputMonth == -1) break;
                d1.Month = inputMonth;
                second commit
            }
            
        }
    }
}
