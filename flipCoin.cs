using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYear
{
    public class flipCoin
    {
        public static void CalculatePersentage()
        {
            Console.WriteLine("Please enter the value for number of flips : ");
            int head = 0;
            int tail = 0;
            int headcout = 0;
            int tailcount = 0;

            double HeadPercentage;
            double tailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if(flipCoin > 0)
            {
                for(int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The Random number generated is : "+number);
                     
                    switch(number)
                    {
                        case 0:
                            tailcount++;
                            break;
                        case 1:
                            headcout++;
                            break;
                    }
                }
                Console.WriteLine("The tail count is "+tailcount);
                Console.WriteLine("The head count is " + headcout);

                HeadPercentage = headcout*100/flipCoin;
                tailPercentage = tailcount*100/flipCoin;

                Console.WriteLine("HeadPersentage is : {0}%",HeadPercentage);
                Console.WriteLine("tailPersentage is : {0}%", tailPercentage);

            }
            else
            {
                Console.WriteLine("Enter the valid number");
            }
        }
    }
}
