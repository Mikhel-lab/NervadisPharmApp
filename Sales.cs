using System;
namespace Nevardis
{
    public class Sales
    {
        public string MedicineCode{get; set;}
        
        public string Region{get;set;}
        private decimal quantitySold;
        public decimal actualSale;
        private decimal plannedSale;
        

        public Sales(string medin, string reg, decimal sold,  decimal actual, decimal plan)
        {
            MedicineCode = medin;
           Region = reg;
           QuantitySold = sold;
           ActualSale = actual;
           PlannedSale = plan;

            
        }

        public decimal QuantitySold
        {
            get{return quantitySold;}
            set
            {
                if(value > 0)
                {
                   quantitySold = value;
                }
            }
        }

        public decimal ActualSale
        {
            get{return actualSale;}
            set{
                if(value > 0)
                {
                    actualSale = value;
                }
            }
        }

           public decimal PlannedSale
        {
            get{return plannedSale;}
            set{
                if(value > 0)
                {
                   plannedSale = value;
                }
            }
        }

        public string Display()
        {
            return $"{MedicineCode}\n{Region}\n{quantitySold}\n{actualSale}\n{plannedSale}";
        }

        public  string Display(decimal actual, decimal sale)
        {
            if(PlannedSale > ActualSale)
            {
                decimal diff = PlannedSale - ActualSale;
                return $"Loss{diff}";
            } else if (ActualSale > PlannedSale)
            {
                decimal diffs = ActualSale - PlannedSale;
                return $"Gain{diffs}";
            } else return "Equilibruim Reach";
        }
    }
}