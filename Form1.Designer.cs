namespace Calendario_02_05_24
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.btnPegarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual :";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(43, 30);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Location = new System.Drawing.Point(522, 78);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(148, 26);
            this.textBoxDataInicial.TabIndex = 5;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Location = new System.Drawing.Point(522, 119);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(148, 26);
            this.textBoxDataFinal.TabIndex = 6;
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Location = new System.Drawing.Point(522, 159);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.Size = new System.Drawing.Size(148, 26);
            this.textBoxDataAtual.TabIndex = 7;
            // 
            // btnPegarData
            // 
            this.btnPegarData.Location = new System.Drawing.Point(413, 223);
            this.btnPegarData.Name = "btnPegarData";
            this.btnPegarData.Size = new System.Drawing.Size(257, 42);
            this.btnPegarData.TabIndex = 8;
            this.btnPegarData.Text = "Selecionar Data";
            this.btnPegarData.UseVisualStyleBackColor = true;
            this.btnPegarData.Click += new System.EventHandler(this.btnPegarData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPegarData);
            this.Controls.Add(this.textBoxDataAtual);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxDataInicial);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox textBoxDataInicial;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.Button btnPegarData;
    }
}

