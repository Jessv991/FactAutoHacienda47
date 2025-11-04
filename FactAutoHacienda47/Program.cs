using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
//using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FactAutoHacienda47
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ApplicationConfiguration.Initialize();

            string tienda = args[1];

            string sql = $"SELECT PAR_Valor FROM TIENDADATOS WHERE TIE_Codigo = '{tienda}' AND PAR_Key = 'TicketBai_Tipo';";

            string TicketBai_Tipo = Conection.SelectOnce(sql).ToUpper();

            if (TicketBai_Tipo == "VERIFACTU")
            {

                //MessageBox.Show("Entró a verifactu");
                VeriFactu form = new VeriFactu();

                if (args.Length >= 3)
                {
                    form.getVEN_Tipo(args[0]);
                    form.getVEN_Tienda(args[1]);
                    form.getVEN_Numfactura(args[2]);

                    if (args.Length >= 4)
                    {
                        form.getVEN_Year(args[3]);

                        if (args.Length >= 5)
                        {
                            form.getReenvio(args[4]);
                        }
                    }
                }
                Application.Run(form);
            }
            else if (TicketBai_Tipo == "TICKETBAI")
            {
                //MessageBox.Show("Entró a ticketbai");
                TicketBai form = new TicketBai();

                if (args.Length >= 3)
                {
                    form.getVEN_Tipo(args[0]);
                    form.getVEN_Tienda(args[1]);
                    form.getVEN_Numfactura(args[2]);

                    if (args.Length >= 4)
                    {
                        form.getVEN_Year(args[3]);

                        if (args.Length >= 5)
                        {
                            form.getReenvio(args[4]);
                        }
                    }
                }
                Application.Run(form);
            }
            else
            {
                MessageBox.Show("Necesitan indicar el TicketBai_Tipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
