using Amazon;
using System;
using System.Reflection.Metadata;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Customer();
            Amazon.RateCalculator = new RateCalculator(); //errored to show protection level
        }
    }
}
