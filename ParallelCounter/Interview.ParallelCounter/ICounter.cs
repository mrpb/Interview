namespace Interview.ParallelCounter
{
    public interface ICounter
    {
        int Value { get; }

        void Increment();
    }
}