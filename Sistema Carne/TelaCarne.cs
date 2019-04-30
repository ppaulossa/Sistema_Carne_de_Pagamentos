using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Carne
{
    public partial class TelaCarne : Form
    {
        private ModeloCarne carne;
        private EscreverWord word;
        private int tudoCerto;
        private bool materias;
        private String message;

        public TelaCarne()
        {
            InitializeComponent();
            carne = new ModeloCarne();
            word = new EscreverWord();
        }

        private void numericUpDownMês_ValueChanged(object sender, EventArgs e)
        {
            Mes.Text = getMes((int)numericUpDownMês.Value);
        }

        private void linkLabelDesenvolvedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nome : Paulo Henrique de Oliveira Sá \n" +
                            "E-mail : ppaulo.sa@hotmail.com \n" +
                            "Celular : 99634-2707 \n", "Desenvolvedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            labelNomeAluno.ForeColor = Color.Black;
            checkBoxInglês.ForeColor = Color.Black;
            checkBoxMatematica.ForeColor = Color.Black;
            checkBoxPortugues.ForeColor = Color.Black;
            textBoxNomeAluno.Text = string.Empty;
            numericUpDownMensalidadeNormal.Value = (decimal)0.00;
            numericUpDownMensalidadeDesconto.Value = (decimal)0.00;
            checkBoxInglês.Checked = checkBoxMatematica.Checked = checkBoxPortugues.Checked = false;
            numericUpDownMês.Value = DateTime.Today.Month;
            Mes.Text = getMes(DateTime.Today.Month);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            message = string.Empty;
            tudoCerto = 0;
            progressBar.Value = 0;
            materias = false;

            message += "****** O FORMULÁRIO CONTÉM ERROS ****** \n\n";

            if (textBoxNomeAluno.TextLength == 0)
            {
                labelNomeAluno.ForeColor = Color.Red;
                message += "- Preencha o nome do aluno. \n";
            }
            else
            {
                labelNomeAluno.ForeColor = Color.Black;
                carne.nomeAluno = textBoxNomeAluno.Text;
                tudoCerto++; // 1
            }

            carne.mensalidadeNormal = numericUpDownMensalidadeNormal.Value.ToString("#,##0.00 R$");
            carne.mensalidadeDesconto = numericUpDownMensalidadeDesconto.Value.ToString("#,##0.00 R$");

            if (checkBoxPortugues.Checked)
            {
                carne.portugues = "X";
                materias = true;
            }else
            {
                carne.portugues = "  ";
            }

            if (checkBoxMatematica.Checked)
            {
                carne.matematica = "X";
                materias = true;
            }else
            {
                carne.matematica = "  ";
            }

            if (checkBoxInglês.Checked)
            {
                carne.ingles = "X";
                materias = true;
            }else
            {
                carne.ingles = "  ";
            }

            if(materias == true)
            {
                checkBoxInglês.ForeColor = Color.Black;
                checkBoxMatematica.ForeColor = Color.Black;
                checkBoxPortugues.ForeColor = Color.Black;
                tudoCerto++; // 2
            }else
            {
                checkBoxInglês.ForeColor = Color.Red;
                checkBoxMatematica.ForeColor = Color.Red;
                checkBoxPortugues.ForeColor = Color.Red;
                message += "- Preencha no mínimo uma diciplina. \n";
            }

            carne.mes = (int) numericUpDownMês.Value;

            if(tudoCerto == 2)
            {
                 word.PreencherNoWord(carne,progressBar);
                 progressBar.Value = 100;
            }else
            {
                MessageBox.Show(message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
