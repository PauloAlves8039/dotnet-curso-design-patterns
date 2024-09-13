namespace DesignPatterns.Curso.PatternsCriacao.Singleton
{
    public class Client
    {
        public void ConsumirDB () 
        {
            var instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("SELECT * FROM Nome_Tabela;");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("INSERT INTO Nome_Tabela (valor) VALUES (0001);");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("UPDATE Nome_Tabela valor=0002 WHERE Id=01;");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("DELETE Nome_Tabela WHERE Id=01;");
        }
    }
}