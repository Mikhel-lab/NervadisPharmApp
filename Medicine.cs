using System;
namespace Nevardis
{
    class Medicine
    {
        public string MedicineCode{get; set;}
        public string MedicineName{get; set;}
        public string ManufacturerName{get; set;}

        public Date ExpireDate{get;set;}
        public int BatchNumber{get;set;}
        private decimal unitPrice;
        private double quantityInStock;
        public Date ManufacturerDate{get;set;}
        

        public Medicine(string med, string name, string manu, Date expire, int number, decimal unit, double quantity, Date date )
        {
            MedicineCode = med;
            MedicineName = name;
            ManufacturerName = manu;
            UnitPrice = unit;
            QuantityInStock = quantity;
            ManufacturerDate = date;
            ExpireDate = expire;
            BatchNumber = number;

            
        }

        public double QuantityInStock
        {
            get{return quantityInStock;}
            set
            {
                if(value > 0)
                {
                   quantityInStock = value;
                }
            }
        }

        public decimal UnitPrice
        {
            get{return unitPrice;}
            set{
                if(value > 0)
                {
                   unitPrice = value;
                }
            }
        }

        //    public string ManufacturerDate
        // {
        //     get{return manufacturerDate;}
        //     set{
        //         if(value > 0)
        //         {
        //             manufacturerDate = value;
        //         }
        //     }
        // }

        public string Print()
        {
            return $"{MedicineCode}\n{MedicineName}\n{ManufacturerName}\n{unitPrice}\n{quantityInStock}\n{ManufacturerDate}\n{ExpireDate}\n{BatchNumber}";
        }
        public string Print(int quantityInStock)
        {
            return $"{quantityInStock}";
        }

        public string Print(Date name, Date code)
        {
            return $"{ExpireDate} and {ManufacturerDate}";
        }

        public string FreshOrder()
        {
            if(quantityInStock == 0)
            {
                 quantityInStock += 50;
            }
              return $"{quantityInStock}";
        }

       
    }
}