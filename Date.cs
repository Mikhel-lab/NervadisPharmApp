using System;
namespace Nevardis
{
    public class Date
    {
        private int day;
        private int month;
        public int Year{get; set;}

        public Date(int theDay, int theMonth, int theYear)
        {
            Day = theDay;
            Month = theMonth;
            Year = theYear;
            Console.WriteLine($"Day Constructor Called: {this}");
        }

        public int Month
        {
            get{return month;}
            private set
            {
                if((value > 0) && (value <= 12))
                {
                     month= value;
                }else {
                    throw new System.ArgumentOutOfRangeException("Day value is out of range");
                }

            }
        }

        public int Day
        {
            get{return day;}
            set 
            {
                
                if((value > 0) && (value <= 31))
                {
                    day = value;
                
                }else{
                    throw new System.ArgumentOutOfRangeException("Day value out of range!");
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}