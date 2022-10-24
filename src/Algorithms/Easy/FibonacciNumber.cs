namespace Algorithms.Easy
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            var sum = 0;
            var prev = 1;
            var temp = 0;

            while (n > 0)
            {
                temp = sum;
                sum += prev;
                prev = temp;

                n--;
            }

            return sum;
        }
    }
}