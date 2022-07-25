using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHVEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnBsc_Click(object sender, EventArgs e)
        {
            Solucoes a =  new Solucoes();

            a.BuscarArquivo(); // utilizando a função buscar

            textBox.Text = a.diretorio;  // abrindo o caminho do arquivo no textBox

            // verifica se usuario indicou um arquivo correto

            if (string.IsNullOrEmpty(a.diretorio))
            {
                MessageBox.Show("Selecione um arquivo valido!");
            } else
            {
                //LIMPANDO O CONTEÚDO DO LISTBOX
                listBox.Items.Clear();

                a.lerArquivo(textBox.Text);


                //APRESENTANDO DADOS DO ARQUIVO NO LISTBOX
                int i = 0;

                string listaArquivo = a.listA[i] + "\t" + a.listB[i];

               listBox.Items.Add(listaArquivo);

                i++;

                while (i < a.quantidadeLinhas)
                {

                    listaArquivo = a.listA[i] + '\t' + '\t' + a.listB[i];

                    listBox.Items.Add(listaArquivo);

                    i++;

                }

            }

            

        }

        private void BtGrafico_Click(object sender, EventArgs e)
        {
            Solucoes a = new Solucoes
            {
                diretorio = textBox.Text
            };

            a.lerArquivo(textBox.Text);

            int i = 1;

            chart1.Series[0].Points.Clear();

            while (i < a.quantidadeLinhas)
            {
                chart1.Series[0].Points.AddXY(a.listB[i], a.listA[i]);
                i++;
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Solucoes a = new Solucoes
            {
                diretorio = textBox.Text
            };

            a.lerArquivo(textBox.Text);


            a.salvarArquivo();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
