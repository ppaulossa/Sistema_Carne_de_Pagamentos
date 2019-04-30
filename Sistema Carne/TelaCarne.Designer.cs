using System;

namespace Sistema_Carne
{
    partial class TelaCarne
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarne));
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.labelMensalidadeNormal = new System.Windows.Forms.Label();
            this.numericUpDownMensalidadeNormal = new System.Windows.Forms.NumericUpDown();
            this.labelRS1 = new System.Windows.Forms.Label();
            this.labelMensalidadeDesconto = new System.Windows.Forms.Label();
            this.numericUpDownMensalidadeDesconto = new System.Windows.Forms.NumericUpDown();
            this.labelRS2 = new System.Windows.Forms.Label();
            this.labelDiciplina = new System.Windows.Forms.Label();
            this.checkBoxPortugues = new System.Windows.Forms.CheckBox();
            this.checkBoxMatematica = new System.Windows.Forms.CheckBox();
            this.checkBoxInglês = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.linkLabelDesenvolvedor = new System.Windows.Forms.LinkLabel();
            this.labelApartir = new System.Windows.Forms.Label();
            this.numericUpDownMês = new System.Windows.Forms.NumericUpDown();
            this.Mes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidadeNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidadeDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMês)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(13, 13);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(89, 13);
            this.labelNomeAluno.TabIndex = 0;
            this.labelNomeAluno.Text = "Nome do Aluno : ";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(108, 10);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(436, 20);
            this.textBoxNomeAluno.TabIndex = 1;
            // 
            // labelMensalidadeNormal
            // 
            this.labelMensalidadeNormal.AutoSize = true;
            this.labelMensalidadeNormal.Location = new System.Drawing.Point(12, 42);
            this.labelMensalidadeNormal.Name = "labelMensalidadeNormal";
            this.labelMensalidadeNormal.Size = new System.Drawing.Size(103, 13);
            this.labelMensalidadeNormal.TabIndex = 2;
            this.labelMensalidadeNormal.Text = "Mensalidade Normal";
            // 
            // numericUpDownMensalidadeNormal
            // 
            this.numericUpDownMensalidadeNormal.DecimalPlaces = 2;
            this.numericUpDownMensalidadeNormal.Location = new System.Drawing.Point(16, 58);
            this.numericUpDownMensalidadeNormal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numericUpDownMensalidadeNormal.Name = "numericUpDownMensalidadeNormal";
            this.numericUpDownMensalidadeNormal.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownMensalidadeNormal.TabIndex = 2;
            // 
            // labelRS1
            // 
            this.labelRS1.AutoSize = true;
            this.labelRS1.Location = new System.Drawing.Point(94, 60);
            this.labelRS1.Name = "labelRS1";
            this.labelRS1.Size = new System.Drawing.Size(21, 13);
            this.labelRS1.TabIndex = 4;
            this.labelRS1.Text = "R$";
            // 
            // labelMensalidadeDesconto
            // 
            this.labelMensalidadeDesconto.AutoSize = true;
            this.labelMensalidadeDesconto.Location = new System.Drawing.Point(141, 42);
            this.labelMensalidadeDesconto.Name = "labelMensalidadeDesconto";
            this.labelMensalidadeDesconto.Size = new System.Drawing.Size(116, 13);
            this.labelMensalidadeDesconto.TabIndex = 5;
            this.labelMensalidadeDesconto.Text = "Mensalidade Desconto";
            // 
            // numericUpDownMensalidadeDesconto
            // 
            this.numericUpDownMensalidadeDesconto.DecimalPlaces = 2;
            this.numericUpDownMensalidadeDesconto.Location = new System.Drawing.Point(144, 58);
            this.numericUpDownMensalidadeDesconto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numericUpDownMensalidadeDesconto.Name = "numericUpDownMensalidadeDesconto";
            this.numericUpDownMensalidadeDesconto.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownMensalidadeDesconto.TabIndex = 3;
            // 
            // labelRS2
            // 
            this.labelRS2.AutoSize = true;
            this.labelRS2.Location = new System.Drawing.Point(223, 61);
            this.labelRS2.Name = "labelRS2";
            this.labelRS2.Size = new System.Drawing.Size(21, 13);
            this.labelRS2.TabIndex = 7;
            this.labelRS2.Text = "R$";
            // 
            // labelDiciplina
            // 
            this.labelDiciplina.AutoSize = true;
            this.labelDiciplina.Location = new System.Drawing.Point(293, 42);
            this.labelDiciplina.Name = "labelDiciplina";
            this.labelDiciplina.Size = new System.Drawing.Size(58, 13);
            this.labelDiciplina.TabIndex = 8;
            this.labelDiciplina.Text = "Diciplinas :";
            // 
            // checkBoxPortugues
            // 
            this.checkBoxPortugues.AutoSize = true;
            this.checkBoxPortugues.Location = new System.Drawing.Point(296, 60);
            this.checkBoxPortugues.Name = "checkBoxPortugues";
            this.checkBoxPortugues.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPortugues.TabIndex = 4;
            this.checkBoxPortugues.Text = "Português";
            this.checkBoxPortugues.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatematica
            // 
            this.checkBoxMatematica.AutoSize = true;
            this.checkBoxMatematica.Location = new System.Drawing.Point(377, 60);
            this.checkBoxMatematica.Name = "checkBoxMatematica";
            this.checkBoxMatematica.Size = new System.Drawing.Size(81, 17);
            this.checkBoxMatematica.TabIndex = 5;
            this.checkBoxMatematica.Text = "Matemática";
            this.checkBoxMatematica.UseVisualStyleBackColor = true;
            // 
            // checkBoxInglês
            // 
            this.checkBoxInglês.AutoSize = true;
            this.checkBoxInglês.Location = new System.Drawing.Point(465, 60);
            this.checkBoxInglês.Name = "checkBoxInglês";
            this.checkBoxInglês.Size = new System.Drawing.Size(54, 17);
            this.checkBoxInglês.TabIndex = 6;
            this.checkBoxInglês.Text = "Inglês";
            this.checkBoxInglês.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(97, 116);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(274, 23);
            this.progressBar.TabIndex = 12;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(469, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(384, 116);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // linkLabelDesenvolvedor
            // 
            this.linkLabelDesenvolvedor.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelDesenvolvedor.AutoSize = true;
            this.linkLabelDesenvolvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDesenvolvedor.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDesenvolvedor.Location = new System.Drawing.Point(12, 128);
            this.linkLabelDesenvolvedor.Name = "linkLabelDesenvolvedor";
            this.linkLabelDesenvolvedor.Size = new System.Drawing.Size(69, 12);
            this.linkLabelDesenvolvedor.TabIndex = 10;
            this.linkLabelDesenvolvedor.TabStop = true;
            this.linkLabelDesenvolvedor.Text = "Desenvolvedor";
            this.linkLabelDesenvolvedor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDesenvolvedor_LinkClicked);
            // 
            // labelApartir
            // 
            this.labelApartir.AutoSize = true;
            this.labelApartir.Location = new System.Drawing.Point(11, 91);
            this.labelApartir.Name = "labelApartir";
            this.labelApartir.Size = new System.Drawing.Size(158, 13);
            this.labelApartir.TabIndex = 16;
            this.labelApartir.Text = "IMPRIMIR A PARTIR DO MÊS ";
            // 
            // numericUpDownMês
            // 
            this.numericUpDownMês.Location = new System.Drawing.Point(175, 89);
            this.numericUpDownMês.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMês.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMês.Name = "numericUpDownMês";
            this.numericUpDownMês.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownMês.TabIndex = 7;
            this.numericUpDownMês.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMês.Value = DateTime.Now.Month;
            this.numericUpDownMês.ValueChanged += new System.EventHandler(this.numericUpDownMês_ValueChanged);
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(221, 91);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(0, 13);
            this.Mes.TabIndex = 18;
            this.Mes.Text = getMes(DateTime.Now.Month);
            // 
            // TelaCarne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 148);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.numericUpDownMês);
            this.Controls.Add(this.labelApartir);
            this.Controls.Add(this.linkLabelDesenvolvedor);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxInglês);
            this.Controls.Add(this.checkBoxMatematica);
            this.Controls.Add(this.checkBoxPortugues);
            this.Controls.Add(this.labelDiciplina);
            this.Controls.Add(this.labelRS2);
            this.Controls.Add(this.numericUpDownMensalidadeDesconto);
            this.Controls.Add(this.labelMensalidadeDesconto);
            this.Controls.Add(this.labelRS1);
            this.Controls.Add(this.numericUpDownMensalidadeNormal);
            this.Controls.Add(this.labelMensalidadeNormal);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCarne";
            this.Opacity = 0.97D;
            this.Text = "Imprimir Carnê";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidadeNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidadeDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMês)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string getMes(int valor)
        {
            switch (valor)
            {
                case 1:
                    return "JANEIRO";
                case 2:
                    return "FEVEREIRO";
                case 3:
                    return "MARÇO";
                case 4:
                    return "ABRIL";
                case 5:
                    return "MAIO";
                case 6:
                    return "JUNHO";
                case 7:
                    return "JULHO";
                case 8:
                    return "AGOSTO";
                case 9:
                    return "SETEMBRO";
                case 10:
                    return "OUTUBRO";
                case 11:
                    return "NOVEMBRO";
                default:
                    return "DEZEMBRO";
            }
        }

        #endregion

        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.Label labelMensalidadeNormal;
        private System.Windows.Forms.NumericUpDown numericUpDownMensalidadeNormal;
        private System.Windows.Forms.Label labelRS1;
        private System.Windows.Forms.Label labelMensalidadeDesconto;
        private System.Windows.Forms.NumericUpDown numericUpDownMensalidadeDesconto;
        private System.Windows.Forms.Label labelRS2;
        private System.Windows.Forms.Label labelDiciplina;
        private System.Windows.Forms.CheckBox checkBoxPortugues;
        private System.Windows.Forms.CheckBox checkBoxMatematica;
        private System.Windows.Forms.CheckBox checkBoxInglês;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.LinkLabel linkLabelDesenvolvedor;
        private System.Windows.Forms.Label labelApartir;
        private System.Windows.Forms.NumericUpDown numericUpDownMês;
        private System.Windows.Forms.Label Mes;
    }
}

