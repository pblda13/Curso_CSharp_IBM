using System.IO;

// Implementação de uma interface para a exportação em arquivo
namespace  Desafio2764
{
    public class ExportarArquivo : IExportarDados
    {
        public void Exportar(string[] datas)
        {
            var contador = 0;

            foreach (var data in datas)
            {
                contador++;

                using (StreamWriter sw = File.AppendText($"Arquivo_{contador}.txt"))
                {
                    sw.Write(data);
                }
            }
        }
    }
}