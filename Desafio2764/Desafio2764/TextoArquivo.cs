using System;
using System.Globalization;
using System.IO;

namespace Desafio2764
{
    class TextoArquivo
    {
        private DateTime Data { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        private string Line { get; set; }
        public TextoArquivo()
        {
        }
        public void LeituraDeArquivo()
        {
            FileStream fs = null;
            StreamReader sr = null;
            string path = @"C:\Users\017542631\source\repos\Curso_de_C_Sharp\Desafio2764\Data_De_Entrada.txt";
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            Line = sr.ReadLine();
            DateTime Data = DateTime.ParseExact(Line, "dd/MM/yy", CultureInfo.InvariantCulture);
            D1 = Data.ToString("MM/dd/yy");
            D2 = Data.ToString("yy/MM/dd");
            D3 = Data.ToString("dd-MM-yy");
        }
        public void EscreverNosArquivos()
        {
            string arquivo2 = @"C:\Users\017542631\source\repos\Curso_de_C_Sharp\Desafio2764\Data_De_Saida_1.txt";
            string arquivo3 = @"C:\Users\017542631\source\repos\Curso_de_C_Sharp\Desafio2764\Data_De_Saida_2.txt";
            string arquivo4 = @"C:\Users\017542631\source\repos\Curso_de_C_Sharp\Desafio2764\Data_De_Saida_3.txt";

            StreamWriter txt1 = new StreamWriter(arquivo2);
            txt1.WriteLine(D1.ToString());
            txt1.Close();
            StreamWriter txt2 = new StreamWriter(arquivo3);
            txt2.WriteLine(D2.ToString());
            txt2.Close();
            StreamWriter txt3 = new StreamWriter(arquivo4);
            txt3.WriteLine(D3.ToString());
            txt3.Close();
        }
    }
}

