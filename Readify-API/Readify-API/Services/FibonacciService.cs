namespace Readify_API.Services
{
    public class FibonacciService
    {
        public FibonacciService()
        {
            
        }


        public static long GetNthFibbinociNumber(long n)
        {
            if ((n == 0) || (n ==1))
            {
                return n;
            }
            return GetNthFibbinociNumber(n - 1) + GetNthFibbinociNumber(n - 2);

        }
    }
}