using DesignPatterns.Curso.PatternsComportamental.Iterator.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.Iterator
{
    public class Aggregate : IAgggregate
    {
        private List<string> Collection = null;
        private int count = 0;


        public Aggregate()
        {
            Collection = new List<string>();
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public string this[int index]
        {
            get
            {
                if (index < Collection.Count)
                {
                    return Collection[index];
                }
                else
                {
                    return String.Empty;
                }
            }
            set
            {
                Collection.Add(value);
            }
        }

        public int Limit
        {
            get
            {
                return Collection.Count;
            }
        }
    }
}