namespace DesignPatterns.Behavioral.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}