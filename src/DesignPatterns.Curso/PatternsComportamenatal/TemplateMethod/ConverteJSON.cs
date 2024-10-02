using DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.AbstractModel;
using DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod
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