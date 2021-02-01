
namespace Interface
{
    partial class frm_ConfirmationBox
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.pic_ProfileImage = new System.Windows.Forms.PictureBox();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbl_Title.Location = new System.Drawing.Point(13, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(70, 27);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(15, 51);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(37, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(15, 90);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(37, 13);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "label1";
            // 
            // pic_ProfileImage
            // 
            this.pic_ProfileImage.Location = new System.Drawing.Point(289, 51);
            this.pic_ProfileImage.Name = "pic_ProfileImage";
            this.pic_ProfileImage.Size = new System.Drawing.Size(103, 104);
            this.pic_ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProfileImage.TabIndex = 3;
            this.pic_ProfileImage.TabStop = false;
            // 
            // btn_Yes
            // 
            this.btn_Yes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.Location = new System.Drawing.Point(236, 166);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(75, 23);
            this.btn_Yes.TabIndex = 4;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Location = new System.Drawing.Point(317, 166);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(75, 23);
            this.btn_No.TabIndex = 5;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // frm_ConfirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.pic_ProfileImage);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ConfirmationBox";
            this.Text = "Confirm information";
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.PictureBox pic_ProfileImage;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
    }
}