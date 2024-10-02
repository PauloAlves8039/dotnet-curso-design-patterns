namespace DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod
{
    public class Client
    {
        public void ConsumirEndpointXML()
        {
            Console.WriteLine("\n____________XML____________\n");

            var xml = ObtemDadosAPI.EndpointXML();
            ConverteXML converteXML = new ConverteXML(xml);

            converteXML.ProcessarXML();
        }

        public void ConsumirEndpointJSON()
        {
            Console.WriteLine("\n____________JSON____________\n");

            var JSON = ObtemDadosAPI.EndpointJSON();
            ConverteJSON convertejson = new ConverteJSON(JSON);

            convertejson.ProcessarJSON();
        }
    }
}