using System.Net.Mail;
using System.Xml.Serialization;
using DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod
{
    public class ObtemDadosAPI
    {
        public static string EndpointXML() 
        {
            List<Pessoa> pessoas = GetPessoas();
            XmlSerializer serializar = new XmlSerializer(pessoas.GetType());
            string xml = String.Empty;

            using(var sw = new StringWriter())
            {
                serializar.Serialize(sw, pessoas);
                xml = sw.ToString(); 
            }

            return xml; 
        }

        public static string EndpointJSON() 
        {
            List<Pessoa> pessoas = GetPessoas();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }
        
        private static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa() 
                {
                    Nome = "José",
                    CPF = "234.445.221-09",
                    Acoes = new List<Acoes>() 
                    {
                        new Acoes("AAAA3",50, 15.44),
                        new Acoes("AAAA4",80, 22.44)
                    }
                },
                new Pessoa() 
                {
                    Nome = "Magali",
                    CPF = "345.556.111-10",
                    Acoes = new List<Acoes>() 
                    {
                        new Acoes("GGGG6",50, 15.44),
                        new Acoes("TRRR3",80, 5.44)
                    }
                }
            };
        }
    }
}