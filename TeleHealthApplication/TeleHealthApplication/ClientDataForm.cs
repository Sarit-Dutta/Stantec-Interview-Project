using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleHealthApplication
{
    public partial class ClientDataForm : Form
    {
        //As in the login form, the first variables are for the client creation to send out requests.
        private static HttpClientHandler handler = new HttpClientHandler() { };
        private static readonly HttpClient client = new HttpClient(handler)
        {
            Timeout = new TimeSpan(0, 1, 0)
        };
        //string to hold the authtoken grabbed from the login form.
        private string authToken;
        //Background worker to enable functions used to clear the fields on submission.
        private BackgroundWorker clearWorker;
        //Delegate for the same field clearing purpose.
        delegate void clearItems();
        // Defining variable that will hold the Delegate
        private clearItems clearDelegate;
        public ClientDataForm(string token)
        {
            InitializeComponent();
            //Initializing the dropdown component and assigning the authtoken received into a local variable for use.
            authToken = token;
            this.provinceDropDown.DisplayMember = "Text";
            this.provinceDropDown.DataSource = new Province[]
            {
                new Province { ID=1, Text="Alberta"},
                new Province { ID=2, Text="British Columia"},
                new Province { ID=3, Text="Manitoba"},
                new Province { ID=4, Text="New Brunswick"},
                new Province { ID=5, Text="Newfoundland and Labrador"},
                new Province { ID=6, Text="Northwest Territories"},
                new Province { ID=7, Text="Nova Scotia"},
                new Province { ID=8, Text="Nunavut"},
                new Province { ID=9, Text="Ontario"},
                new Province { ID=10, Text="Prince Edward Island"},
                new Province { ID=11, Text="Quebec"},
                new Province { ID=12, Text="Saskatchewan"},
                new Province { ID=13, Text="Yukon"}
            };
            //Initializing the Delegate and the Background worker that will handle its execution.
            clearWorker = new BackgroundWorker();
            clearWorker.DoWork += new DoWorkEventHandler(clearText);
            clearDelegate = new clearItems(clearComplete);
            // Defining the headers for the client that will be used repeatedly.
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            string val = authToken;
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + val);
        }

        //Logout button execution.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            // Message box opens that notifies the user of required fields.
            if (getFirstName() == "" || getLastName() == "")
            {
                MessageBox.Show("The First and Last Name fields must be filled.");
                return;
            }

            if (getConcerns() == "" || getResponse() == "" || getPostalCode() == "")
            {
                MessageBox.Show("The Concerns and Reponse fields must be filled.");
                return;
            }

            // Defining request body.
            var body = new ClientBody
            {
                firstName = getFirstName(),
                middleName = getMiddleName(),
                lastName = getLastName(),
                phoneNumber = getPhoneNumber(),
                address = getAddress(),
                city = getCity(),
                province = getProvince().Text,
                postalCode = getPostalCode(),
                concerns = getConcerns(),
                response = getResponse()
            };

            try
            {
                //Building the request.
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:5001/api/clients", body).ConfigureAwait(false);
                string responseState = response.StatusCode.ToString();

                //If the request is successful then show success message and clear the fields.
                if (responseState == "Created")
                {
                    MessageBox.Show("Successfully Recorded Data!");
                    clearWorker.RunWorkerAsync();

                }
                else
                {
                    //Else extract the error portion of the response and display within a Message.Box
                    var data = await response.Content.ReadAsStringAsync();
                    var deserializedContent = JObject.Parse(data);
                    
                    MessageBox.Show("Submission failed. Try again soon.\n" + deserializedContent["errors"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return;
            }
        }

        //Function that invokes the delegate from within the backgtround worker to clear the fields.
        private void clearText(object sender, DoWorkEventArgs e)
        {
            this.Invoke(clearDelegate);
        }

        //Function that clears the fields. Invoked by the clearText Function executed by the background worker.
        private void clearComplete()
        {
            firstNameInput.Text = "";
            middleNameInput.Text = "";
            lastNameInput.Text = "";
            phoneNumberInput.Text = "";
            addressInput.Text = "";
            cityInput.Text = "";
            postalCodeInput.Text = "";
            concernsInput.Text = "";
            responseInput.Text = "";
        }
    }
}
