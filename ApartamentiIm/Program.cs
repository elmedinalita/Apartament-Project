using System;
using System.Windows.Forms;

namespace ApartamentiIm
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Kyqu());
            Application.Run(new Members());
        }
    }
}
