
namespace Interface
{
    partial class frm_StudentRegistration_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_MonitorInfo = new System.Windows.Forms.Label();
            this.cb_Monitor = new System.Windows.Forms.CheckBox();
            this.msk_Registry = new System.Windows.Forms.MaskedTextBox();
            this.msk_HouseNumber = new System.Windows.Forms.MaskedTextBox();
            this.msk_Discount = new System.Windows.Forms.MaskedTextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Registry = new System.Windows.Forms.Label();
            this.cb_ManualRegistry = new System.Windows.Forms.CheckBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Neighborhood = new System.Windows.Forms.TextBox();
            this.lbl_Neighborhood = new System.Windows.Forms.Label();
            this.lbl_HouseNumber = new System.Windows.Forms.Label();
            this.txt_StreetName = new System.Windows.Forms.TextBox();
            this.lbl_StreetName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_PostalCode = new System.Windows.Forms.MaskedTextBox();
            this.lbl_StudentRegistration = new System.Windows.Forms.Label();
            this.btn_SubmitForm = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MonitorInfo
            // 
            this.lbl_MonitorInfo.AutoSize = true;
            this.lbl_MonitorInfo.Font = new System.Drawing.Font("Roboto", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonitorInfo.Location = new System.Drawing.Point(67, 339);
            this.lbl_MonitorInfo.Name = "lbl_MonitorInfo";
            this.lbl_MonitorInfo.Size = new System.Drawing.Size(218, 13);
            this.lbl_MonitorInfo.TabIndex = 45;
            this.lbl_MonitorInfo.Text = "*Monitors have 100% of discount over their tuition";
            // 
            // cb_Monitor
            // 
            this.cb_Monitor.AutoSize = true;
            this.cb_Monitor.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Monitor.Location = new System.Drawing.Point(165, 166);
            this.cb_Monitor.Name = "cb_Monitor";
            this.cb_Monitor.Size = new System.Drawing.Size(70, 17);
            this.cb_Monitor.TabIndex = 30;
            this.cb_Monitor.Text = "Monitor*";
            this.cb_Monitor.UseVisualStyleBackColor = true;
            // 
            // msk_Registry
            // 
            this.msk_Registry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Registry.Location = new System.Drawing.Point(116, 137);
            this.msk_Registry.Mask = "000";
            this.msk_Registry.Name = "msk_Registry";
            this.msk_Registry.ReadOnly = true;
            this.msk_Registry.Size = new System.Drawing.Size(21, 21);
            this.msk_Registry.TabIndex = 27;
            // 
            // msk_HouseNumber
            // 
            this.msk_HouseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_HouseNumber.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_HouseNumber.Location = new System.Drawing.Point(155, 217);
            this.msk_HouseNumber.Mask = "0000";
            this.msk_HouseNumber.Name = "msk_HouseNumber";
            this.msk_HouseNumber.Size = new System.Drawing.Size(262, 21);
            this.msk_HouseNumber.TabIndex = 34;
            // 
            // msk_Discount
            // 
            this.msk_Discount.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Discount.Location = new System.Drawing.Point(118, 164);
            this.msk_Discount.Mask = "00%";
            this.msk_Discount.Name = "msk_Discount";
            this.msk_Discount.Size = new System.Drawing.Size(41, 21);
            this.msk_Discount.TabIndex = 28;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(123, 113);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(294, 21);
            this.txt_Password.TabIndex = 25;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Password:";
            // 
            // lbl_Registry
            // 
            this.lbl_Registry.AutoSize = true;
            this.lbl_Registry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registry.Location = new System.Drawing.Point(58, 142);
            this.lbl_Registry.Name = "lbl_Registry";
            this.lbl_Registry.Size = new System.Drawing.Size(52, 13);
            this.lbl_Registry.TabIndex = 43;
            this.lbl_Registry.Text = "Registry:";
            // 
            // cb_ManualRegistry
            // 
            this.cb_ManualRegistry.AutoSize = true;
            this.cb_ManualRegistry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ManualRegistry.Location = new System.Drawing.Point(143, 139);
            this.cb_ManualRegistry.Name = "cb_ManualRegistry";
            this.cb_ManualRegistry.Size = new System.Drawing.Size(124, 17);
            this.cb_ManualRegistry.TabIndex = 26;
            this.cb_ManualRegistry.Text = "Manual registration";
            this.cb_ManualRegistry.UseVisualStyleBackColor = true;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(58, 168);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(54, 13);
            this.lbl_Discount.TabIndex = 42;
            this.lbl_Discount.Text = "Discount:";
            // 
            // txt_City
            // 
            this.txt_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_City.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_City.Location = new System.Drawing.Point(103, 269);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(314, 21);
            this.txt_City.TabIndex = 36;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(58, 273);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(30, 13);
            this.lbl_City.TabIndex = 41;
            this.lbl_City.Text = "City:";
            // 
            // txt_Neighborhood
            // 
            this.txt_Neighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Neighborhood.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Neighborhood.Location = new System.Drawing.Point(143, 243);
            this.txt_Neighborhood.Name = "txt_Neighborhood";
            this.txt_Neighborhood.Size = new System.Drawing.Size(274, 21);
            this.txt_Neighborhood.TabIndex = 35;
            // 
            // lbl_Neighborhood
            // 
            this.lbl_Neighborhood.AutoSize = true;
            this.lbl_Neighborhood.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Neighborhood.Location = new System.Drawing.Point(58, 247);
            this.lbl_Neighborhood.Name = "lbl_Neighborhood";
            this.lbl_Neighborhood.Size = new System.Drawing.Size(79, 13);
            this.lbl_Neighborhood.TabIndex = 40;
            this.lbl_Neighborhood.Text = "Neighborhood:";
            // 
            // lbl_HouseNumber
            // 
            this.lbl_HouseNumber.AutoSize = true;
            this.lbl_HouseNumber.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HouseNumber.Location = new System.Drawing.Point(58, 221);
            this.lbl_HouseNumber.Name = "lbl_HouseNumber";
            this.lbl_HouseNumber.Size = new System.Drawing.Size(91, 13);
            this.lbl_HouseNumber.TabIndex = 37;
            this.lbl_HouseNumber.Text = "House\'s number:";
            // 
            // txt_StreetName
            // 
            this.txt_StreetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StreetName.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StreetName.Location = new System.Drawing.Point(136, 191);
            this.txt_StreetName.Name = "txt_StreetName";
            this.txt_StreetName.Size = new System.Drawing.Size(281, 21);
            this.txt_StreetName.TabIndex = 31;
            // 
            // lbl_StreetName
            // 
            this.lbl_StreetName.AutoSize = true;
            this.lbl_StreetName.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StreetName.Location = new System.Drawing.Point(58, 195);
            this.lbl_StreetName.Name = "lbl_StreetName";
            this.lbl_StreetName.Size = new System.Drawing.Size(72, 13);
            this.lbl_StreetName.TabIndex = 33;
            this.lbl_StreetName.Text = "Street name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Postal code:";
            // 
            // msk_PostalCode
            // 
            this.msk_PostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_PostalCode.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_PostalCode.Location = new System.Drawing.Point(133, 295);
            this.msk_PostalCode.Mask = "00000-000";
            this.msk_PostalCode.Name = "msk_PostalCode";
            this.msk_PostalCode.Size = new System.Drawing.Size(284, 21);
            this.msk_PostalCode.TabIndex = 38;
            // 
            // lbl_StudentRegistration
            // 
            this.lbl_StudentRegistration.AutoSize = true;
            this.lbl_StudentRegistration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentRegistration.Location = new System.Drawing.Point(66, 53);
            this.lbl_StudentRegistration.Name = "lbl_StudentRegistration";
            this.lbl_StudentRegistration.Size = new System.Drawing.Size(153, 19);
            this.lbl_StudentRegistration.TabIndex = 29;
            this.lbl_StudentRegistration.Text = "Student Registration";
            // 
            // btn_SubmitForm
            // 
            this.btn_SubmitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SubmitForm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitForm.Location = new System.Drawing.Point(356, 330);
            this.btn_SubmitForm.Name = "btn_SubmitForm";
            this.btn_SubmitForm.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitForm.TabIndex = 39;
            this.btn_SubmitForm.Text = "Submit";
            this.btn_SubmitForm.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(103, 87);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(314, 21);
            this.txt_Name.TabIndex = 24;
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(58, 91);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(40, 13);
            this.lbl_name.TabIndex = 23;
            this.lbl_name.Text = "Name:";
            // 
            // frm_StudentRegistration_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lbl_MonitorInfo);
            this.Controls.Add(this.cb_Monitor);
            this.Controls.Add(this.msk_Registry);
            this.Controls.Add(this.msk_HouseNumber);
            this.Controls.Add(this.msk_Discount);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Registry);
            this.Controls.Add(this.cb_ManualRegistry);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txt_Neighborhood);
            this.Controls.Add(this.lbl_Neighborhood);
            this.Controls.Add(this.lbl_HouseNumber);
            this.Controls.Add(this.txt_StreetName);
            this.Controls.Add(this.lbl_StreetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msk_PostalCode);
            this.Controls.Add(this.lbl_StudentRegistration);
            this.Controls.Add(this.btn_SubmitForm);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_name);
            this.Name = "frm_StudentRegistration_UC";
            this.Size = new System.Drawing.Size(488, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MonitorInfo;
        private System.Windows.Forms.CheckBox cb_Monitor;
        private System.Windows.Forms.MaskedTextBox msk_Registry;
        private System.Windows.Forms.MaskedTextBox msk_HouseNumber;
        private System.Windows.Forms.MaskedTextBox msk_Discount;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Registry;
        private System.Windows.Forms.CheckBox cb_ManualRegistry;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Neighborhood;
        private System.Windows.Forms.Label lbl_Neighborhood;
        private System.Windows.Forms.Label lbl_HouseNumber;
        private System.Windows.Forms.TextBox txt_StreetName;
        private System.Windows.Forms.Label lbl_StreetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_PostalCode;
        private System.Windows.Forms.Label lbl_StudentRegistration;
        private System.Windows.Forms.Button btn_SubmitForm;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_name;
    }
}
