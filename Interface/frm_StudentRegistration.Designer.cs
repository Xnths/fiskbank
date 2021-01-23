
namespace UserInterface
{
    partial class frm_StudentRegistration
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ApplicationName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_SubmitForm = new System.Windows.Forms.Button();
            this.lbl_StudentInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_PostalCode = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StreetName = new System.Windows.Forms.TextBox();
            this.lbl_StreetName = new System.Windows.Forms.Label();
            this.lbl_HouseNumber = new System.Windows.Forms.Label();
            this.txt_Neighborhood = new System.Windows.Forms.TextBox();
            this.lbl_Neighborhood = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.cb_ManualRegistry = new System.Windows.Forms.CheckBox();
            this.lbl_Registry = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_Discount = new System.Windows.Forms.MaskedTextBox();
            this.msk_HouseNumber = new System.Windows.Forms.MaskedTextBox();
            this.msk_Registry = new System.Windows.Forms.MaskedTextBox();
            this.cb_Monitor = new System.Windows.Forms.CheckBox();
            this.lbl_MonitorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(10, 82);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(40, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_ApplicationName
            // 
            this.lbl_ApplicationName.AutoSize = true;
            this.lbl_ApplicationName.Font = new System.Drawing.Font("Roboto Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplicationName.Location = new System.Drawing.Point(10, 13);
            this.lbl_ApplicationName.Name = "lbl_ApplicationName";
            this.lbl_ApplicationName.Size = new System.Drawing.Size(102, 27);
            this.lbl_ApplicationName.TabIndex = 1;
            this.lbl_ApplicationName.Text = "FiskBank";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(55, 78);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(314, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // btn_SubmitForm
            // 
            this.btn_SubmitForm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitForm.Location = new System.Drawing.Point(302, 324);
            this.btn_SubmitForm.Name = "btn_SubmitForm";
            this.btn_SubmitForm.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitForm.TabIndex = 12;
            this.btn_SubmitForm.Text = "Submit";
            this.btn_SubmitForm.UseVisualStyleBackColor = true;
            this.btn_SubmitForm.Click += new System.EventHandler(this.btn_SubmitForm_Click);
            // 
            // lbl_StudentInfo
            // 
            this.lbl_StudentInfo.AutoSize = true;
            this.lbl_StudentInfo.Location = new System.Drawing.Point(12, 331);
            this.lbl_StudentInfo.Name = "lbl_StudentInfo";
            this.lbl_StudentInfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_StudentInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Registration";
            // 
            // msk_PostalCode
            // 
            this.msk_PostalCode.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_PostalCode.Location = new System.Drawing.Point(85, 286);
            this.msk_PostalCode.Mask = "00000-000";
            this.msk_PostalCode.Name = "msk_PostalCode";
            this.msk_PostalCode.Size = new System.Drawing.Size(284, 21);
            this.msk_PostalCode.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Postal code:";
            // 
            // txt_StreetName
            // 
            this.txt_StreetName.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StreetName.Location = new System.Drawing.Point(88, 182);
            this.txt_StreetName.Name = "txt_StreetName";
            this.txt_StreetName.Size = new System.Drawing.Size(281, 21);
            this.txt_StreetName.TabIndex = 7;
            // 
            // lbl_StreetName
            // 
            this.lbl_StreetName.AutoSize = true;
            this.lbl_StreetName.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StreetName.Location = new System.Drawing.Point(10, 186);
            this.lbl_StreetName.Name = "lbl_StreetName";
            this.lbl_StreetName.Size = new System.Drawing.Size(72, 13);
            this.lbl_StreetName.TabIndex = 8;
            this.lbl_StreetName.Text = "Street name:";
            // 
            // lbl_HouseNumber
            // 
            this.lbl_HouseNumber.AutoSize = true;
            this.lbl_HouseNumber.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HouseNumber.Location = new System.Drawing.Point(10, 212);
            this.lbl_HouseNumber.Name = "lbl_HouseNumber";
            this.lbl_HouseNumber.Size = new System.Drawing.Size(91, 13);
            this.lbl_HouseNumber.TabIndex = 10;
            this.lbl_HouseNumber.Text = "House\'s number:";
            // 
            // txt_Neighborhood
            // 
            this.txt_Neighborhood.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Neighborhood.Location = new System.Drawing.Point(95, 234);
            this.txt_Neighborhood.Name = "txt_Neighborhood";
            this.txt_Neighborhood.Size = new System.Drawing.Size(274, 21);
            this.txt_Neighborhood.TabIndex = 9;
            // 
            // lbl_Neighborhood
            // 
            this.lbl_Neighborhood.AutoSize = true;
            this.lbl_Neighborhood.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Neighborhood.Location = new System.Drawing.Point(10, 238);
            this.lbl_Neighborhood.Name = "lbl_Neighborhood";
            this.lbl_Neighborhood.Size = new System.Drawing.Size(79, 13);
            this.lbl_Neighborhood.TabIndex = 12;
            this.lbl_Neighborhood.Text = "Neighborhood:";
            // 
            // txt_City
            // 
            this.txt_City.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_City.Location = new System.Drawing.Point(55, 260);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(314, 21);
            this.txt_City.TabIndex = 10;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(10, 264);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(30, 13);
            this.lbl_City.TabIndex = 14;
            this.lbl_City.Text = "City:";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(10, 159);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(54, 13);
            this.lbl_Discount.TabIndex = 16;
            this.lbl_Discount.Text = "Discount:";
            // 
            // cb_ManualRegistry
            // 
            this.cb_ManualRegistry.AutoSize = true;
            this.cb_ManualRegistry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ManualRegistry.Location = new System.Drawing.Point(95, 130);
            this.cb_ManualRegistry.Name = "cb_ManualRegistry";
            this.cb_ManualRegistry.Size = new System.Drawing.Size(124, 17);
            this.cb_ManualRegistry.TabIndex = 3;
            this.cb_ManualRegistry.Text = "Manual registration";
            this.cb_ManualRegistry.UseVisualStyleBackColor = true;
            this.cb_ManualRegistry.CheckedChanged += new System.EventHandler(this.cb_ManualRegistry_CheckedChanged);
            // 
            // lbl_Registry
            // 
            this.lbl_Registry.AutoSize = true;
            this.lbl_Registry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registry.Location = new System.Drawing.Point(10, 133);
            this.lbl_Registry.Name = "lbl_Registry";
            this.lbl_Registry.Size = new System.Drawing.Size(52, 13);
            this.lbl_Registry.TabIndex = 19;
            this.lbl_Registry.Text = "Registry:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(75, 104);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(294, 21);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password:";
            // 
            // msk_Discount
            // 
            this.msk_Discount.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Discount.Location = new System.Drawing.Point(70, 155);
            this.msk_Discount.Mask = "00%";
            this.msk_Discount.Name = "msk_Discount";
            this.msk_Discount.Size = new System.Drawing.Size(41, 21);
            this.msk_Discount.TabIndex = 5;
            // 
            // msk_HouseNumber
            // 
            this.msk_HouseNumber.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_HouseNumber.Location = new System.Drawing.Point(107, 208);
            this.msk_HouseNumber.Mask = "0000";
            this.msk_HouseNumber.Name = "msk_HouseNumber";
            this.msk_HouseNumber.Size = new System.Drawing.Size(262, 21);
            this.msk_HouseNumber.TabIndex = 8;
            // 
            // msk_Registry
            // 
            this.msk_Registry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Registry.Location = new System.Drawing.Point(68, 128);
            this.msk_Registry.Mask = "000";
            this.msk_Registry.Name = "msk_Registry";
            this.msk_Registry.ReadOnly = true;
            this.msk_Registry.Size = new System.Drawing.Size(21, 21);
            this.msk_Registry.TabIndex = 4;
            // 
            // cb_Monitor
            // 
            this.cb_Monitor.AutoSize = true;
            this.cb_Monitor.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Monitor.Location = new System.Drawing.Point(117, 157);
            this.cb_Monitor.Name = "cb_Monitor";
            this.cb_Monitor.Size = new System.Drawing.Size(70, 17);
            this.cb_Monitor.TabIndex = 6;
            this.cb_Monitor.Text = "Monitor*";
            this.cb_Monitor.UseVisualStyleBackColor = true;
            this.cb_Monitor.CheckedChanged += new System.EventHandler(this.cb_Monitor_CheckedChanged);
            // 
            // lbl_MonitorInfo
            // 
            this.lbl_MonitorInfo.AutoSize = true;
            this.lbl_MonitorInfo.Font = new System.Drawing.Font("Roboto", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonitorInfo.Location = new System.Drawing.Point(19, 330);
            this.lbl_MonitorInfo.Name = "lbl_MonitorInfo";
            this.lbl_MonitorInfo.Size = new System.Drawing.Size(218, 13);
            this.lbl_MonitorInfo.TabIndex = 22;
            this.lbl_MonitorInfo.Text = "*Monitors have 100% of discount over their tuition";
            // 
            // frm_StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 359);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_StudentInfo);
            this.Controls.Add(this.btn_SubmitForm);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_ApplicationName);
            this.Controls.Add(this.lbl_name);
            this.Name = "frm_StudentRegistration";
            this.Text = "FiskBank";
            this.Load += new System.EventHandler(this.frm_StudentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ApplicationName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_SubmitForm;
        private System.Windows.Forms.Label lbl_StudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_PostalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StreetName;
        private System.Windows.Forms.Label lbl_StreetName;
        private System.Windows.Forms.Label lbl_HouseNumber;
        private System.Windows.Forms.TextBox txt_Neighborhood;
        private System.Windows.Forms.Label lbl_Neighborhood;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.CheckBox cb_ManualRegistry;
        private System.Windows.Forms.Label lbl_Registry;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_Discount;
        private System.Windows.Forms.MaskedTextBox msk_HouseNumber;
        private System.Windows.Forms.MaskedTextBox msk_Registry;
        private System.Windows.Forms.CheckBox cb_Monitor;
        private System.Windows.Forms.Label lbl_MonitorInfo;
    }
}

