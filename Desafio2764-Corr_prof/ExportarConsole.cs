using System;

// implementação de uma interface para a exibição no console
namespace  Desafio2764
{
    public class ExportarConsole : IExportarDados
    {
        public void Exportar(string[] datas)
        {
            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }
        }
    }
}