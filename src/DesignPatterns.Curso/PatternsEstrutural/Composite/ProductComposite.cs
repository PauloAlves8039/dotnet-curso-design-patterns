using DesignPatterns.Curso.PatternsEstrutural.Composite.Model;

namespace DesignPatterns.Curso.PatternsEstrutural.Composite
{
    public class ProductComposite : ComponentModel
    {
        private List<ComponentModel> _components;

        public ProductComposite()
        {
            _components = new List<ComponentModel>();
        }

        public override void Add(params ComponentModel[] components)
        {
            _components.AddRange(components);
        }

        public override ComponentModel GetChild(int index)
        {
            if (_components.Count == 0) 
            {
                Console.WriteLine("Não possui produtos cadastrados.");
                return null;
            }

            return _components[index];
        }

        public override double Operation()
        {
            double valorTotal = 0;

            for (int i = 0; i < _components.Count; i++)
            {
                var component = _components[i];
                var child = component.GetChild(i);
                valorTotal += component.Operation();
            }

            return valorTotal;
        }

        public override void Remove(ComponentModel component)
        {
            _components.Remove(component);
        }
    }
}