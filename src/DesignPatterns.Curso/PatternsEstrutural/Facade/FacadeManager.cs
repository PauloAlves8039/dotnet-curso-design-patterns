using DesignPatterns.Curso.PatternsEstrutural.Facade.AmbienteComplexo;

namespace DesignPatterns.Curso.PatternsEstrutural.Facade
{
    public class FacadeManager
    {
        public void ExecutarComplexidade() 
        {
            var zonaNorte = new ZonaNorte();
            var zonaSul = new ZonaSul();
            var cloud = new CloudComputing();

            var sul = zonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);
            var norte = zonaNorte.ExecutaRotinaVendasPerdidas(DateTime.Now);

            cloud.GerarRelatorioPerdasGanhos(sul, norte);
        }
    }
}