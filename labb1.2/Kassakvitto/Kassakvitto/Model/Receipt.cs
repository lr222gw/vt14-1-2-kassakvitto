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
            Subtotal = subtotal;

            if (Subtotal <= 499)
            {
                DiscountRate = 0.0;
            }
            else if (Subtotal <= 999)
            {
                DiscountRate = 0.05;
            }
            else if (Subtotal <= 4999)
            {
                DiscountRate = 0.10;
            }
            else if (Subtotal >= 5000)
            {
                DiscountRate = 0.15;
            }

            MoneyOff = Subtotal * DiscountRate;

            Total = Subtotal - MoneyOff;
            
        }

        public Receipt(double subtotal)
        {
            //Subtotal = subtotal;

            Calculate(subtotal); //exekverar Calculate metoden som räknar ut all data..
        }




    }
}