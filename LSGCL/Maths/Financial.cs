using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSGCL.Maths
{
    public class Financial
    {
        public static double SimpleInterest(double amount,double rate,double time)
        {
            double interestEarned = 0;

            interestEarned = amount * (1 + ((rate / 100) * time));

            return interestEarned;
        }

        public static double CompundInterest(double amount, double rate, double time)
        {
            double totalAmount = 0;

            totalAmount = amount * (Math.Pow(1 + (rate / 100), time));

            return totalAmount;
        }

        public static double SimpleDepraciation(double amount, double rate, double time)
        {
            double reducedAmount = 0;

            reducedAmount = amount * (1- ((rate / 100) * time));

            return reducedAmount;
        }

        public static double CompoundDepraciation(double amount, double rate, double time)
        {
            double reducedAmount = 0;

            reducedAmount = amount * (Math.Pow(1 - (rate / 100), time));

            return reducedAmount;
        }

        public static double NominalToEffective(double nominalRate,double time, double period)
        {
            double rate = 0;

            rate = (Math.Pow(1 + ((nominalRate / 100) / period), period) - 1);

            return rate;
        }

        public static double EffectiveToNominal(double effectiveRate,double time,double period)
        {
            double rate = 0;

            rate = period * (Math.Pow(1 + (effectiveRate / 100),1 / period) - 1);

            return rate;
        }

    }
}