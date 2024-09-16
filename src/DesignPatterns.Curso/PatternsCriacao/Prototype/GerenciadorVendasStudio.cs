namespace DesignPatterns.Curso.PatternsCriacao.Prototype
{
    public class GerenciadorVendasStudio
    {
        private Dictionary<string, StudioModel> studioModel = new Dictionary<string, StudioModel>();

        public StudioModel this[string key] 
        {
            get { return studioModel[key]; }
            set { studioModel[key] = value; }
        }
    }
}