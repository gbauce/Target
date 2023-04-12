using System;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            // Calcula faturamento total
            double total = sp + rj + mg + es + outros;

            // Calcula o percentual de cada estado
            double percSP = (sp / total) * 100;
            double percRJ = (rj / total) * 100;
            double percMG = (mg / total) * 100;
            double percES = (es / total) * 100;
            double percOutros = (outros / total) * 100;

            // Exibe os resultados
            Console.WriteLine("Faturamento mensal por estado:");
            Console.WriteLine("SP - R$ " + sp.ToString("F2") + " (" + percSP.ToString("F2") + "%)");
            Console.WriteLine("RJ - R$ " + rj.ToString("F2") + " (" + percRJ.ToString("F2") + "%)");
            Console.WriteLine("MG - R$ " + mg.ToString("F2") + " (" + percMG.ToString("F2") + "%)");
            Console.WriteLine("ES - R$ " + es.ToString("F2") + " (" + percES.ToString("F2") + "%)");
            Console.WriteLine("Outros - R$ " + outros.ToString("F2") + " (" + percOutros.ToString("F2") + "%)");
        }
    }
}
