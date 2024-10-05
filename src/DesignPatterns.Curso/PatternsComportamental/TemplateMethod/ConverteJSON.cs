using DesignPatterns.Curso.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatterns.Curso.PatternsComportamental.TemplateMethod.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Curso.PatternsComportamental.TemplateMethod
{
    public class ConverteJSON : ProcessaDados
    {
        public ConverteJSON(string json) : base(json:json) { }

        public override void ProcessarJSON()
        {
            this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);
            this.ApresentarValores();
        }
    }
}