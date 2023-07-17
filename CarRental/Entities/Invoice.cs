﻿using System.Globalization;

namespace Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTax: " + Tax +
                "\nTotal Payment: " + TotalPayment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
