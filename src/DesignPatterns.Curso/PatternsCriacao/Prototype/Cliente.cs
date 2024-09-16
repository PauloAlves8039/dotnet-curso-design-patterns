namespace DesignPatterns.Curso.PatternsCriacao.Prototype
{
    public class Cliente
    {
        public void ConsumirDadosStudios() 
        {
            var gerenciador = new GerenciadorVendasStudio();

            gerenciador["24m"] = new Studio("24m^2", "FinaEmpreendimentos", 180000.00M);
            gerenciador["26m"] = new Studio("26m^2", "Financiamnetos Imóveis Aurora", 190000.00M);
            gerenciador["28m"] = new Studio("28m^2", "Imóveis Tabajara", 200000.00M);

            StudioModel firstClone01 = gerenciador["24m"].Clone();
            StudioModel firstClone02 = gerenciador["24m"].Clone();
            StudioModel studio26 = gerenciador["26m"].Clone();
            StudioModel studio28 = gerenciador["28m"].Clone();
        }
    }
}