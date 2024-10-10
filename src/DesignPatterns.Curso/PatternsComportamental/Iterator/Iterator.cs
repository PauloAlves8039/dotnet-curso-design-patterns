using DesignPatterns.Curso.PatternsComportamental.Iterator.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.Iterator
{
    public class Iterator : IIterator
    {
        private IAgggregate _agggregate;
        private int _position;

        public Iterator(IAgggregate agggregate, int position = 0)
        {
            _agggregate = agggregate;
            _position = position;
        }

        public string Next
        {
            get
            {
                return _agggregate[_position++];
            }
        }


        public bool HasNext 
        {
            get
            {
                return _position <= _agggregate.Limit;
            }
        }
    }
}