using System;
using Word = Microsoft.Office.Interop;
using System.Windows.Forms;

namespace Sistema_Carne
{
    class EscreverWord
    {
        private QuintoDiaUtil quintoDia;

         public EscreverWord()
        {
            quintoDia = new QuintoDiaUtil();
        }
        public void PreencherNoWord(ModeloCarne modeloCarne, ProgressBar progressBar)
        {
            int quantosCarnes;

            object campoBranco = System.Reflection.Missing.Value;
            Word.Word.Application oApp = new Word.Word.Application();
            progressBar.Value = 2;
            object caminhoContrato = System.IO.Path.GetFullPath("Carne\\" + modeloCarne.mes + ".docx");
            progressBar.Value = 4;
            Word.Word.Document contrato = oApp.Documents.Add(ref caminhoContrato, false, ref campoBranco, false);
            progressBar.Value = 6;
            mudarTudo(contrato, campoBranco, modeloCarne.nomeAluno, "[nomealuno]");
            progressBar.Value = 8;
            mudarTudo(contrato, campoBranco, modeloCarne.mensalidadeNormal, "[valornormal]");
            progressBar.Value = 10;
            mudarTudo(contrato, campoBranco, modeloCarne.mensalidadeDesconto, "[valordesconto]");
            progressBar.Value = 12;
            mudarTudo(contrato, campoBranco, modeloCarne.portugues, "[P]");
            progressBar.Value = 16;
            mudarTudo(contrato, campoBranco, modeloCarne.matematica, "[M]");
            progressBar.Value = 18;
            mudarTudo(contrato, campoBranco, modeloCarne.ingles, "[I]");
            progressBar.Value = 20;

            if(modeloCarne.mes <= 9)
            {
                quantosCarnes = 9 - (modeloCarne.mes - 1);

                for(int x = 1; x <= quantosCarnes; x++)
                {
                    progressBar.Value += 80 / quantosCarnes;
                    mudarTudo(contrato, campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year, modeloCarne.mes + (x-1)),"[" + x + "]");
                }
            }else
            {
               
                if(modeloCarne.mes == 10)
                {
                    for(int x = 1; x <= 3; x++)
                    {
                        progressBar.Value += 80 / 12;
                        mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year, modeloCarne.mes + (x - 1)), "[" + x + "]");
                    }

                    for(int x = 4; x <= 12; x++)
                    {
                        progressBar.Value += 80 / 12;
                        mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year + 1,(x - 3)), "[" + x + "]");
                    }

                }else if(modeloCarne.mes == 11)
                {
                    for (int x = 1; x <= 2; x++)
                    {
                        progressBar.Value += 80 / 11;
                        mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year, modeloCarne.mes + (x - 1)), "[" + x + "]");
                    }

                    for (int x = 3; x <= 11; x++)
                    {
                        progressBar.Value += 80 / 11;
                        mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year + 1,(x - 2)), "[" + x + "]");
                    }

                }
                else
                {
                    progressBar.Value += 80 / 10;
                    mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year,12), "[1]");

                    for (int x = 2; x <= 10; x++)
                    {
                        progressBar.Value += 80 / 10;
                        mudarTudo(contrato,campoBranco, quintoDia.RetornaQuintoDiaUtil(DateTime.Now.Year + 1,(x - 1)), "[" + x + "]");
                    }

                }
            }

            oApp.Visible = true;
        }

        public void mudarTudo(Word.Word.Document contrato, object branco, string substituir, string encontrarTexto)
        {
            Word.Word.Range mudar = contrato.Range(ref branco, ref branco);

            object FindText = encontrarTexto;
            object ReplaceWith = substituir;
            object MatchWholeWord = true;
            object Forward = false;

            mudar.Find.Execute(ref FindText, ref branco, ref MatchWholeWord, ref branco, ref branco, ref branco, ref Forward, ref branco, ref branco,
                              ref ReplaceWith, Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll, ref branco, ref branco, ref branco);
        }
    }
}
