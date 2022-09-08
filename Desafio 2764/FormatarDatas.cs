using System;
using System.IO;

namespace  Desafio2764
{
    //Atributos da classe
    // Readonly - Especifica que uma variável ou propriedade pode ser lida, mas não gravada.
    class FormatarDatas
    {
        private readonly string _caminhoArquivo;
        private string[] _datas;

        //Construtor
        public FormatarDatas(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        //Leitura de todas as linhas do arquivo indicado,no formato de data 
        private DateTime LerArquivo()
        {
            return DateTime.Parse(File.ReadAllLines(_caminhoArquivo)[0]);
        }

        //Conversão das datas em diferentes formatos especificados,utlizando vetor para guardar  
        private string[] ConverterDataEmDiferentesFormatos(DateTime data)
        {
            return new string[]
            {
                data.ToString("MM/dd/yy"),
                data.ToString("yy/MM/dd"),
                data.ToString("dd-MM-yy")
            };
        }

        public void Converter()
        {
            var data = LerArquivo();
            _datas = ConverterDataEmDiferentesFormatos(data);
        }

        public void ExportarDados(IExportarDados exportarDados)
        {
            exportarDados.Exportar(_datas);
        }
    }
}
