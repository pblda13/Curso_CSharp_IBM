using System;
using System.Collections.Generic;
using System.IO;

namespace Desafio2764
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatarDatas = new FormatarDatas("minhaData.txt");
            formatarDatas.Converter();

            var listaDeExportacao = new List<IExportarDados>();
            listaDeExportacao.Add(new ExportarConsole());

            foreach (var exportacao in listaDeExportacao)
            {
                formatarDatas.ExportarDados(exportacao);
            }
        }
    }
}
