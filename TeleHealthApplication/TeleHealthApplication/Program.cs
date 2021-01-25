using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleHealthApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            string authToken;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Creates new login form that users will encounter upon opening the appliation.
            logInForm login = new logInForm();
            //While users do not manually close the window, it will remain open and await log in procedures
            while (login.DialogResult != DialogResult.Cancel)
            {
                login.ShowDialog();
                //Extracting auth token for the post methods within the Client Data Form
                authToken = login.authToken;
                // If successful login, then the token will be passed to the newly generated Client Data Form.
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new ClientDataForm(authToken));
            }
        }
    }
}
