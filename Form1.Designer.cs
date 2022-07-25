using System;

namespace FormHVEX
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox = new System.Windows.Forms.ListBox();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.BtGrafico = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(505, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(426, 553);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(120, 55);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(345, 550);
            this.listBox.TabIndex = 1;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(23, 12);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 77);
            this.BtBuscar.TabIndex = 2;
            this.BtBuscar.Text = "Buscar Arquivo";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtnBsc_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(120, 15);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(642, 20);
            this.textBox.TabIndex = 3;
            // 
            // BtGrafico
            // 
            this.BtGrafico.Location = new System.Drawing.Point(22, 245);
            this.BtGrafico.Name = "BtGrafico";
            this.BtGrafico.Size = new System.Drawing.Size(75, 81);
            this.BtGrafico.TabIndex = 4;
            this.BtGrafico.Text = "Gerar Gráfico";
            this.BtGrafico.UseVisualStyleBackColor = true;
            this.BtGrafico.Click += new System.EventHandler(this.BtGrafico_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(22, 463);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 85);
            this.BtSalvar.TabIndex = 5;
            this.BtSalvar.Text = "Salvar Dados";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 635);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtGrafico);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button BtGrafico;
        private System.Windows.Forms.Button BtSalvar;
        private EventHandler textBox_TextChanged;
    }
}

