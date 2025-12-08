namespace TipsAndTricks.Delegates
{
    public class Delegates
    {
        // Without Delegate
        public int Add(int x, int y) => x + y;
        public int Multiply(int x, int y) => x * y;

        public int Sum() => Add(2, 3);

        // Old Delegate
        public delegate int MathOperation(int x, int y);

        public int SumWithDelegates()
        {
            MathOperation op = Add;

            return op(2, 3);
        }

        // New Delegate
        Func<int, int, int> operation = (x, y) => x + y;
        public int SumWithNewerDelegate() => operation(2, 3);
    }
}
