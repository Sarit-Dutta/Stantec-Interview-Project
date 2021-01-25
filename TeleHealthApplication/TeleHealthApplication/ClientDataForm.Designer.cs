
namespace TeleHealthApplication
{
    partial class ClientDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOutButton = new System.Windows.Forms.Button();
            this.clientFormDescriptionTitle = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameInput = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.provinceDropDown = new System.Windows.Forms.ComboBox();
            this.concernsLabel = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.concernsInput = new System.Windows.Forms.TextBox();
            this.responseInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(825, 17);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(101, 40);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientFormDescriptionTitle
            // 
            this.clientFormDescriptionTitle.AutoSize = true;
            this.clientFormDescriptionTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFormDescriptionTitle.Location = new System.Drawing.Point(27, 25);
            this.clientFormDescriptionTitle.Name = "clientFormDescriptionTitle";
            this.clientFormDescriptionTitle.Size = new System.Drawing.Size(757, 32);
            this.clientFormDescriptionTitle.TabIndex = 1;
            this.clientFormDescriptionTitle.Text = "Please enter client information below in the appropriate fields.";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.Location = new System.Drawing.Point(189, 98);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(249, 39);
            this.firstNameInput.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(27, 101);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(156, 32);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name:";
            // 
            // middleNameInput
            // 
            this.middleNameInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameInput.Location = new System.Drawing.Point(677, 98);
            this.middleNameInput.Name = "middleNameInput";
            this.middleNameInput.Size = new System.Drawing.Size(249, 39);
            this.middleNameInput.TabIndex = 17;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.Location = new System.Drawing.Point(468, 101);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(196, 32);
            this.middleNameLabel.TabIndex = 16;
            this.middleNameLabel.Text = "Middle Names:";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(189, 156);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(249, 39);
            this.lastNameInput.TabIndex = 19;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(27, 159);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(154, 32);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInput.Location = new System.Drawing.Point(677, 156);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(249, 39);
            this.phoneNumberInput.TabIndex = 21;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(468, 159);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(203, 32);
            this.phoneNumberLabel.TabIndex = 20;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeInput.Location = new System.Drawing.Point(677, 280);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(249, 39);
            this.postalCodeInput.TabIndex = 29;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeLabel.Location = new System.Drawing.Point(468, 283);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(171, 32);
            this.postalCodeLabel.TabIndex = 28;
            this.postalCodeLabel.Text = "Postal Code:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLabel.Location = new System.Drawing.Point(27, 283);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(127, 32);
            this.provinceLabel.TabIndex = 26;
            this.provinceLabel.Text = "Province:";
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.Location = new System.Drawing.Point(677, 218);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(249, 39);
            this.cityInput.TabIndex = 25;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(468, 221);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(71, 32);
            this.cityLabel.TabIndex = 24;
            this.cityLabel.Text = "City:";
            // 
            // addressInput
            // 
            this.addressInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInput.Location = new System.Drawing.Point(189, 218);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(249, 39);
            this.addressInput.TabIndex = 23;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(27, 221);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(123, 32);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "Address:";
            // 
            // provinceDropDown
            // 
            this.provinceDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.provinceDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.provinceDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceDropDown.DropDownWidth = 300;
            this.provinceDropDown.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceDropDown.FormattingEnabled = true;
            this.provinceDropDown.Location = new System.Drawing.Point(189, 279);
            this.provinceDropDown.Name = "provinceDropDown";
            this.provinceDropDown.Size = new System.Drawing.Size(249, 40);
            this.provinceDropDown.TabIndex = 30;
            // 
            // concernsLabel
            // 
            this.concernsLabel.AutoSize = true;
            this.concernsLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concernsLabel.Location = new System.Drawing.Point(172, 351);
            this.concernsLabel.Name = "concernsLabel";
            this.concernsLabel.Size = new System.Drawing.Size(140, 32);
            this.concernsLabel.TabIndex = 31;
            this.concernsLabel.Text = "Concerns:";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseLabel.Location = new System.Drawing.Point(638, 351);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(146, 32);
            this.responseLabel.TabIndex = 32;
            this.responseLabel.Text = "Response:";
            // 
            // concernsInput
            // 
            this.concernsInput.Font = new System.Drawing.Font("Arial", 16F);
            this.concernsInput.Location = new System.Drawing.Point(38, 403);
            this.concernsInput.Multiline = true;
            this.concernsInput.Name = "concernsInput";
            this.concernsInput.Size = new System.Drawing.Size(419, 300);
            this.concernsInput.TabIndex = 33;
            // 
            // responseInput
            // 
            this.responseInput.Font = new System.Drawing.Font("Arial", 16F);
            this.responseInput.Location = new System.Drawing.Point(493, 403);
            this.responseInput.Multiline = true;
            this.responseInput.Name = "responseInput";
            this.responseInput.Size = new System.Drawing.Size(433, 300);
            this.responseInput.TabIndex = 34;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(425, 734);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 40);
            this.submitButton.TabIndex = 35;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ClientDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 795);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.responseInput);
            this.Controls.Add(this.concernsInput);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.concernsLabel);
            this.Controls.Add(this.provinceDropDown);
            this.Controls.Add(this.postalCodeInput);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameInput);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.clientFormDescriptionTitle);
            this.Controls.Add(this.logOutButton);
            this.Name = "ClientDataForm";
            this.Text = "Input Client Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label clientFormDescriptionTitle;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox middleNameInput;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox postalCodeInput;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.ComboBox provinceDropDown;
        private System.Windows.Forms.Label concernsLabel;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.TextBox concernsInput;
        private System.Windows.Forms.TextBox responseInput;
        private System.Windows.Forms.Button submitButton;

        public string getFirstName()
        {
            return firstNameInput.Text;
        }

        public string getMiddleName()
        {
            return middleNameInput.Text;
        }

        public string getLastName()
        {
            return lastNameInput.Text;
        }

        public string getPhoneNumber()
        {
            return phoneNumberInput.Text;
        }

        public string getAddress()
        {
            return addressInput.Text;
        }

        public string getCity()
        {
            return cityInput.Text;
        }

        public Province getProvince()
        {
            return (Province)provinceDropDown.SelectedValue;
        }

        public string getPostalCode()
        {
            return postalCodeInput.Text;
        }

        public string getConcerns()
        {
            return concernsInput.Text;
        }

        public string getResponse()
        {
            return responseInput.Text;
        }
    }
}