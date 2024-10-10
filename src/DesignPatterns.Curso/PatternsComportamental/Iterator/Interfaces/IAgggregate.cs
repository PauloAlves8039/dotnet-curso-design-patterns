namespace DesignPatterns.Curso.PatternsComportamental.Iterator.Interfaces
{
    public interface IAgggregate
    {
        IIterator GetIterator();
        string this[int index] { set; get; }
        public int Limit { get; }
    }
}