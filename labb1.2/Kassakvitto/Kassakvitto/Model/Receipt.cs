using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kassakvitto.Model
{
    public class Receipt
    {
        //fält
        private double _subtotal;

        //Egenskaper
        public double Subtotal
        {
            get { return _subtotal; }
            set { 
                if(value > 0){
                    _subtotal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                 
            }
        }

        public double DiscountRate
        {
            get;
            set;
        }

        public double MoneyOff
        {
            get;
            set;
        }

        public double Total
        {
            get;
            set;
        }

        //Metoder
        public void Calculate(double subtotal)
        {

            if (subtotal <= 499 || subtotal > 0)
            {
                DiscountRate = 0.0;
            }
            else if (subtotal <= 999 || subtotal > 499)
            {
                DiscountRate = 0.05;
            }
            else if (subtotal <= 4999 || subtotal > 999)
            {
                DiscountRate = 0.10;
            }
            else if (subtotal > 5000)
            {
                DiscountRate = 0.15;
            }

            MoneyOff = subtotal * DiscountRate;

            Total = subtotal - MoneyOff;
            
        }

        public Receipt(double subtotal)
        {
            Subtotal = subtotal;
        }




    }
}