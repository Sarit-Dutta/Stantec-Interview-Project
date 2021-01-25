using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace TeleHealthApplication
{
    public partial class logInForm : Form
    {
        //Defining httpclient variable and a handler to deal with outgoing and incoming requests/responses.
        private static HttpClientHandler handler = new HttpClientHandler() { };
        private static readonly HttpClient client = new HttpClient(handler)
        {
            Timeout = new TimeSpan(0, 1, 0)
        };

        public string authToken;

        public logInForm()
        {
            InitializeComponent();
            loginButton.Click += new EventHandler(loginButton_Click);
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
        }

        //Ignore this function.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Functionality that executes once the login button is clicked on the form.
        private async void loginButton_Click(object sender, EventArgs e)
        {
            //Should the username and password be empty, then a message box pops up informing the user of this missing info.
            if (getUsernameInput() == "" || getPasswordInput() == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }

            // LoginInfo class is used to create and hold the JSON properties for use within the request body.
            var body = new LoginInfo
            {
                userName = getUsernameInput(),
                password = getPasswordInput()
            };

            try
            {
                // Organizing the headers and auth token portions of the request.
                var plainTextBytes = Encoding.UTF8.GetBytes(getUsernameInput() + ":" + getPasswordInput());
                string val = Convert.ToBase64String(plainTextBytes);
                if (!client.DefaultRequestHeaders.Contains("Authorization"))
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + val);
                }
                //Organizing the request, the url and its body and configuring the function to await its response before progressing.
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:5001/api/user/authenticate", body).ConfigureAwait(false);
                //Obtain the request
                string responseState = response.StatusCode.ToString();
                //If successful, then return an Ok state for the dialogue box and continue on.
                if (responseState == "OK")
                {
                    //Display success in a message box, hold token in a proprerty for extraction
                    MessageBox.Show("Successful Login. Welcome!");
                    this.authToken = val;
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    //Error message if failure during request. Eg. Bad credentials.
                    MessageBox.Show("Login failed. Try again soon.");
                    return;
                }

            } catch (Exception error)
            {
                // Shows other possible excpetions that may be encountered during execution.
                MessageBox.Show(error.ToString());
                return;
            }
        }

        //Function made to return Cancel status for the dialog box so that the application can end execution.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
