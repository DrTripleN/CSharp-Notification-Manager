using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301231884_Needham__Lab2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dictionary<string, int> emailSubs = new Dictionary<string, int>();
            Dictionary<string, int> smsSubs = new Dictionary<string, int>();
            Application.Run(new Form1(emailSubs,smsSubs));
        }
    }
}
