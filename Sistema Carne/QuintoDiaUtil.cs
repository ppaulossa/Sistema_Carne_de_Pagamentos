using System;

namespace Sistema_Carne
{
    class QuintoDiaUtil
    {
        public string RetornaQuintoDiaUtil(int ano, int mes)
        {
            DateTime Data = new DateTime(ano, mes, 1);
            Int32 primeiroDiaUtil = RetornaPrimeiroDiaUtil(Data);

            Int32 auxDiasUteisLocalizados = 1;
            Int32 auxContadorDiaVerificados = 1;
            DateTime quintoDiaUtil = DateTime.Now;
            DateTime dataPrimeiroDiaUtil = new DateTime(Data.Year, Data.Month, primeiroDiaUtil);

            while (auxDiasUteisLocalizados < 5)
            {
                quintoDiaUtil = dataPrimeiroDiaUtil.AddDays(auxContadorDiaVerificados);

                if (VerificaDiaUtil(quintoDiaUtil))
                {
                    auxDiasUteisLocalizados++;
                }

                auxContadorDiaVerificados++;
            }

            return quintoDiaUtil.ToShortDateString();
        }

        private int RetornaPrimeiroDiaUtil(DateTime Data)
        {
            while (!VerificaDiaUtil(Data))
            {
                Data = Data.AddDays(1f);
            }
            return Data.Day;
        }

        private bool VerificaDiaUtil(DateTime DiaMes)
        {
            if (DiaMes.DayOfWeek == DayOfWeek.Saturday || DiaMes.DayOfWeek == DayOfWeek.Sunday ||
                VerificaFeriado(DiaMes))
            {
                return false;
            }

            return true;
        }

        private bool VerificaFeriado(DateTime DiaMes)
        {
            if (DiaMes.Month == 1 || DiaMes.Month == 5 || DiaMes.Month == 9 || DiaMes.Month == 11)
            {
                if (DiaMes == Convert.ToDateTime("02/11/" + DiaMes.Year))
                {
                    return true; // Finados
                }
                else if (DiaMes == Convert.ToDateTime("07/09/" + DiaMes.Year))
                {
                    return true; // Dia da Indenpendência
                }
                else if (DiaMes == Convert.ToDateTime("01/05/" + DiaMes.Year))
                {
                    return true; // Dia do Trabalhador
                }
                else if (DiaMes == Convert.ToDateTime("01/01/" + DiaMes.Year))
                {
                    return true; // Confraternização
                }
            }

            return false;
        }
    }

}

