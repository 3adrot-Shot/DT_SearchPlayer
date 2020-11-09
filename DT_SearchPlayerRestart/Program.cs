using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_SearchPlayerRestart
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        ///
        public static Connector Connector;
        public static Form1 Form1;
        public static Form2 f2;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 = new Form1();
            f2 = new Form2();
            Connector = new Connector();
            Task.Run(() => Connector.Start());
            Application.Run(Form1);
        }
    }
}
