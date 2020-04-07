using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
   
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); //part of same assembly (internal)
            var rating = calculator.Calculate();
            Console.WriteLine("promoted");
        }
    }
}
