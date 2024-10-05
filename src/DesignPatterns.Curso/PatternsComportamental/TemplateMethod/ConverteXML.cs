using System.Xml;
using System.Xml.Serialization;
using DesignPatterns.Curso.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatterns.Curso.PatternsComportamental.TemplateMethod.Models;

namespace DesignPatterns.Curso.PatternsComportamental.TemplateMethod
{
    public class ConverteXML : ProcessaDados
    {
        public ConverteXML(string xml) : base(xml:xml) { }

        public override void ProcessarXML()
        {
            XmlSerializer serializer = new XmlSerializer(this.pessoas.GetType());
            
            var stringReader = new StringReader(this.xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);
            }

            this.ApresentarValores();
        }
    }
}