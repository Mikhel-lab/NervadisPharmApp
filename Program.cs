using System;

namespace Nevardis
{
    class Program
    {
        static void Main(string[] args)
        {
               Date manuDate = new Date(19,03,1999);
              Date exDate = new Date(23,04,1889);
            Medicine medicine = new Medicine("6464", "John", "Ben", exDate, 32, 3400, 56.60, manuDate );
            Sales salesss = new Sales("4567", "Lagos", 5078, 0056, 4584);
         
          

            Console.WriteLine(medicine.Print());
            Console.WriteLine(salesss.Display(300,500));
            Console.WriteLine(medicine.Print(manuDate, exDate));


            
        }
    }
}
