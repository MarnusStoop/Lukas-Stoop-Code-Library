using System;

namespace LSGCL.Maths
{
    /// <summary>
    /// A static class for sequencial computations
    /// </summary>
    public static class Sequences
    {
        public static double CalculateArithmeticTerm(double difference, double firstTerm, int termToFind)
        {
            double sum = 0;

            sum = firstTerm + ((termToFind - 1) * difference);

            return sum;
        }

        public static double CalculateGeometricTerm(double ratio, double firstTerm, int termToFind)
        {
            double sum = 0;

            sum = firstTerm * Math.Pow(ratio, termToFind - 1);

            return sum;
        }

        public static double CalculateArithmeticSum(double difference, double firstTerm, int seriesLength, int startTermNumber)
        {
            double sum = 0;
            seriesLength++;
            int nLength = seriesLength - startTermNumber;

            if(startTermNumber > 1)
            {
                seriesLength--;
                nLength = seriesLength;
                sum = (nLength / 2) * ((2 * firstTerm) + ((nLength - 1) * difference));
                nLength = startTermNumber;
                sum -= (nLength / 2) * ((2 * firstTerm) + ((nLength - 1) * difference));
                return sum;
            }

            sum = (nLength / 2) * ((2 * firstTerm) + ((nLength - 1) * difference));

            return sum;
        }

        public static double CalculateGeometricSum(double ratio, double firstTerm, int seriesLength, int startTermNumber)
        {
            double sum = 0;
            seriesLength++;
            int nLength = seriesLength - startTermNumber;

            if(ratio == 1)
            {
                Exception ratiois1 = new Exception("The ratio is not allowed to equal 1");
                throw ratiois1;
            }

            if(startTermNumber > 1)
            {
                seriesLength--;
                nLength = seriesLength;
                sum = firstTerm * ((1 - Math.Pow(ratio, nLength)) / (1 - ratio));
                nLength = startTermNumber;
                sum -= firstTerm * ((1 - Math.Pow(ratio, nLength)) / (1 - ratio));
                return sum;
            }

            sum = firstTerm * ((1 - Math.Pow(ratio, nLength)) / (1 - ratio));

            return sum;
        }
    }
}