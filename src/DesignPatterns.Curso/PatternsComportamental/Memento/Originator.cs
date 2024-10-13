namespace DesignPatterns.Curso.PatternsComportamental.Memento
{
    public class Originator
    {
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine($"Estado atual do vídeo: {_estado}");
            }
        }

        public Snapshot CreateSnapshot()
        {
            return (new Snapshot(_estado));
        }

        public void Restore(Snapshot snapshot)
        {
            Console.WriteLine("Restaurando estado. . .");
            Estado = snapshot.GetState();
        }
    }
}