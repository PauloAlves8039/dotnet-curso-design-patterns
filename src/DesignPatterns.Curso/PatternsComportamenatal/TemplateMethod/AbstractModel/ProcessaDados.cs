using DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.Models;

namespace DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.AbstractModel
{
    public abstract class ProcessaDados
    {
        protected List<Pessoa> pessoas;
        protected string json;
        protected string xml;
        
        public virtual void ProcesarXML() {}
        public virtual void ProcesarJSON() {}

        public void ApresentarValores() {}

        public ProcessaDados()
        {
        }

        protected ProcessaDados(string json = "", string xml = "")
        {
            if(!string.IsNullOrEmpty(json)) 
            {
                this.json = json;
            }
            else if (!string.IsNullOrEmpty(xml)) 
            {
                this.xml = xml;
            }
            
            this.json = json;
            this.xml = xml;
        }
    }
}