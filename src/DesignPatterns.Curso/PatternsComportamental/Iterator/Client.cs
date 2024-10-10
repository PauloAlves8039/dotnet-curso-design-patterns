using DesignPatterns.Curso.PatternsComportamental.Iterator.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.Iterator
{
    public class Client
    {
        public void CosumirEstrutaDados()
        {
            Aggregate aggregate = new Aggregate();

            aggregate[0] = "Item 01";
            aggregate[1] = "Item 02";
            aggregate[2] = "Item 03";

            IIterator iterator = aggregate.GetIterator();


            for(string item = iterator.Next; iterator.HasNext; item = iterator.Next)
            {
                Console.WriteLine(item);
            }

        }
    }
}