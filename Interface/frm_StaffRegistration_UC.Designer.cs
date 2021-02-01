
namespace Interface
{
    partial class frm_StaffRegistration_UC
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
            this.lbl_StaffRegistration = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_ProfilePicture = new System.Windows.Forms.Label();
            this.pic_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StaffRegistration
            // 
            this.lbl_StaffRegistration.AutoSize = true;
            this.lbl_StaffRegistration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffRegistration.Location = new System.Drawing.Point(4, 4);
            this.lbl_StaffRegistration.Name = "lbl_StaffRegistration";
            this.lbl_StaffRegistration.Size = new System.Drawing.Size(186, 27);
            this.lbl_StaffRegistration.TabIndex = 0;
            this.lbl_StaffRegistration.Text = "Staff Registration";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Location = new System.Drawing.Point(47, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(331, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(6, 45);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(43, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name: ";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(6, 71);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(19, 13);
            this.lbl_Id.TabIndex = 4;
            this.lbl_Id.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Id.Location = new System.Drawing.Point(47, 68);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(331, 20);
            this.txt_Id.TabIndex = 3;
            // 
            // lbl_ProfilePicture
            // 
            this.lbl_ProfilePicture.AutoSize = true;
            this.lbl_ProfilePicture.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfilePicture.Location = new System.Drawing.Point(6, 97);
            this.lbl_ProfilePicture.Name = "lbl_ProfilePicture";
            this.lbl_ProfilePicture.Size = new System.Drawing.Size(78, 13);
            this.lbl_ProfilePicture.TabIndex = 6;
            this.lbl_ProfilePicture.Text = "Profile Picture";
            // 
            // pic_ProfilePicture
            // 
            this.pic_ProfilePicture.Location = new System.Drawing.Point(90, 97);
            this.pic_ProfilePicture.Name = "pic_ProfilePicture";
            this.pic_ProfilePicture.Size = new System.Drawing.Size(133, 118);
            this.pic_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProfilePicture.TabIndex = 7;
            this.pic_ProfilePicture.TabStop = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(314, 263);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseFile.Location = new System.Drawing.Point(229, 146);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(141, 23);
            this.btn_ChooseFile.TabIndex = 9;
            this.btn_ChooseFile.Text = "Choose File...";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // frm_StaffRegistration_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.pic_ProfilePicture);
            this.Controls.Add(this.lbl_ProfilePicture);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_StaffRegistration);
            this.Name = "frm_StaffRegistration_UC";
            this.Size = new System.Drawing.Size(392, 289);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StaffRegistration;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_ProfilePicture;
        private System.Windows.Forms.PictureBox pic_ProfilePicture;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ChooseFile;
    }
}
