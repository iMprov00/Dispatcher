using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }

        public static List<Form> formsContext = new List<Form>();
        public static void btnBack_Click(object sender, EventArgs e)
        {
            if(formsContext.Count != 0)
            {
                formsContext[formsContext.Count - 2].Show();
                formsContext[formsContext.Count - 1].Close();
                formsContext.RemoveAt(formsContext.Count - 1);
            }
        }
    }
}
