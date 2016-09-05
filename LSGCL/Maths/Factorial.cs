namespace LSGCL.Maths
{
    /// <summary>
    /// A static class for factorial computations
    /// </summary>
    public static class Factorial
    {
        /// <summary>
        /// Calculates a supplied number's factorial 
        /// </summary>
        /// <param name="i">The number to calculate</param>
        /// <returns>The factorial</returns>
        public static int Calculate(int i)
        {
            int sum = i;

            for(int x = 1;x < i - 1;x++)
            {
                sum *= (i - x);
            }

            return sum;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factorials"></param>
        /// <returns></returns>
        public static int SubtractFactorials(params int[] factorials)
        {
            int[] calculatedFactorials = new int[factorials.Length];
            for(int i = 0;i < factorials.Length;i++)
            {
                calculatedFactorials[i] = Calculate(factorials[i]);
            }
            int difference = calculatedFactorials[0];
            for(int i = 1;i < calculatedFactorials.Length;i++)
            {
                difference -= calculatedFactorials[i];
            }
            return difference;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factorials"></param>
        /// <returns></returns>
        public static int AddFactorials(params int[] factorials)
        {
            int[] calculatedFactorials = new int[factorials.Length];
            for(int i = 0;i < factorials.Length;i++)
            {
                calculatedFactorials[i] = Calculate(factorials[i]);
            }
            int sum = calculatedFactorials[0];
            for(int i = 1;i < calculatedFactorials.Length;i++)
            {
                sum += calculatedFactorials[i];
            }
            return sum;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factorials"></param>
        /// <returns></returns>
        public static int MultiplyFactorials(params int[] factorials)
        {
            int[] calculatedFactorials = new int[factorials.Length];
            for(int i = 0;i < factorials.Length;i++)
            {
                calculatedFactorials[i] = Calculate(factorials[i]);
            }
            int product = calculatedFactorials[0];
            for(int i = 1;i < calculatedFactorials.Length;i++)
            {
                product *= calculatedFactorials[i];
            }
            return product;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factorials"></param>
        /// <returns></returns>
        public static double DivideFactorials(params int[] factorials)
        {
            int[] calculatedFactorials = new int[factorials.Length];
            for(int i = 0;i < factorials.Length;i++)
            {
                calculatedFactorials[i] = Calculate(factorials[i]);
            }
            double qoutient = calculatedFactorials[0];
            for(int i = 1;i < calculatedFactorials.Length;i++)
            {
                if(calculatedFactorials[i] == 0)
                {
                    continue;
                }
                qoutient /= calculatedFactorials[i];
            }
            return qoutient;
        }
    }
}