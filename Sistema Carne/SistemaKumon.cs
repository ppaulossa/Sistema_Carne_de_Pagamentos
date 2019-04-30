using System;
using System.Windows.Forms;

namespace Sistema_Carne
{
    static class SistemaKumon
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaCarne());
        }
    }
}
