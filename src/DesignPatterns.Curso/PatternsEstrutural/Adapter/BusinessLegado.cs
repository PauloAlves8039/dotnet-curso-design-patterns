namespace DesignPatterns.Curso.PatternsEstrutural.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes) 
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            var time = 3000;

            Console.WriteLine("\nProcessando regras de negócio contas a pagar...");
            Thread.Sleep(time);

            return result;
        }

        public string ExecutarRotinaContasReceber(string mes) 
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            var time = 3000;

            Console.WriteLine("\nProcessando regras de negócio contas a receber...");
            Thread.Sleep(time);

            return result;
        }
    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes) 
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("junho", "junho\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("julho", "julho\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("agosto", "agosto\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("setembro", "setembro\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("outubro", "outubro\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");

            return dic[mes];
        }

        public static string GetDadosReceber(string mes) 
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("junho", "junho\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("julho", "julho\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("agosto", "agosto\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("setembro", "setembro\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");
            dic.Add("outubro", "outubro\nCNPJ:32643030000102\nRazão social: Lojas Prudente\nValor: 1200.00\nContato: (11) 1232-2333");

            return dic[mes];
        }
    }
}