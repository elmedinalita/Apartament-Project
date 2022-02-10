using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ApartamentiIm
{
    public class Program
    {
        public static BindingList<Perdorues> Users = new BindingList<Perdorues>();

        [STAThread]
        static void Main()
        {
            Users.Add(new Perdorues
            {
                Id = 1,
                Emri = "User1@email.com",
                Fjalkalimi = "Pass123456"
            });
            Users.Add(new Perdorues
            {
                Id = 2,
                Emri = "User2@email.com",
                Fjalkalimi = "Pass123456"
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kyqu());
        }
    }
}
