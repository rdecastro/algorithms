namespace aum.Algorithms
{
    /// <summary>
    /// Index:              0  1  2  3  4  5  6  7   8   9   10  11  12   ...
    /// Fibonacci Number:   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
    /// </summary>
    public class FibonacciSequence
    {
        private const short Two = 2;

        public int GetByIndex(int index)
        {
            if (IsIndexLessThanTwo(index))
                return index;
            else
                return GetByIndex(index - 1) + GetByIndex(index - 2);
        }

        private static bool IsIndexLessThanTwo(int index)
        {
            return index < Two;
        }
    }
}
