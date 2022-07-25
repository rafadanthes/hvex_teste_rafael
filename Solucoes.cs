using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using MongoDB.Driver;

namespace FormHVEX
{
    internal class Solucoes
    {
        public string diretorio;

        public int quantidadeLinhas;

        public List<string> listA = new List<string>();

        public List<string> listB = new List<string>();


        public void BuscarArquivo()
        {

                OpenFileDialog arquivo = new OpenFileDialog();
            
                arquivo.InitialDirectory = @"C:\"; // abre a janela para selecionar o arquivo

                arquivo.Filter = "All Files(*.csv)| *.csv";  // filtra para abrir somente arquivos csv

                arquivo.FilterIndex = 1; // valor referente ao tipo de filtro que esta sendo utilizado

                arquivo.Multiselect = false; // desabilitando o multiselect

                DialogResult resposta = arquivo.ShowDialog();

                if (resposta == DialogResult.OK)
                {

                //pega o caminho do arquivo especificado

                    diretorio = arquivo.FileName;

                }
            


        }
        public void lerArquivo(string diretorio)
        {

            var leitura = new StreamReader(File.OpenRead(diretorio));

            string linha = leitura.ReadLine();

            string[] valor = linha.Split('\t');

            listA.Add(valor[0]);

            listB.Add(valor[1]);

            while (!leitura.EndOfStream)
            {
                quantidadeLinhas = listA.Count;

                linha = leitura.ReadLine();

                valor = linha.Split('\t', '\t', '\t');

                if (valor.Length == 4)
                {
                    listA.Add(valor[0]);

                    listB.Add(valor[3]);
                }

            }

        }
        public void salvarArquivo()
        {
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");

                var meteorologia = client.GetDatabase("meteorologia");

                var temperatura = meteorologia.GetCollection<meteorologia>("temperatura");

                var clixtemp = new meteorologia();

                int i = 1;

                while (i < quantidadeLinhas)
                {
                    clixtemp.temperatura = listA[i];
                    clixtemp.tempo = listB[i];

                    //GRAVANDO DADOS
                    temperatura.InsertOne(clixtemp);

                    i++;
                }

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao gravar dados!");
            }
            
        }

        public class meteorologia
        {
            public string temperatura { get; set; }

            public string tempo { get; set; }
        }

    }
}