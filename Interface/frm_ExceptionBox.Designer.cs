
namespace Interface
{
    partial class frm_ExceptionBox
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
            this.lbl_ExceptionMessage = new System.Windows.Forms.Label();
            this.pic_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(13, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(62, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            // 
            // lbl_ExceptionMessage
            // 
            this.lbl_ExceptionMessage.AutoSize = true;
            this.lbl_ExceptionMessage.Font = new System.Drawing.Font("Roboto", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExceptionMessage.Location = new System.Drawing.Point(148, 64);
            this.lbl_ExceptionMessage.Name = "lbl_ExceptionMessage";
            this.lbl_ExceptionMessage.Size = new System.Drawing.Size(40, 14);
            this.lbl_ExceptionMessage.TabIndex = 1;
            this.lbl_ExceptionMessage.Text = "label2";
            // 
            // pic_Picture
            // 
            this.pic_Picture.Location = new System.Drawing.Point(12, 35);
            this.pic_Picture.Name = "pic_Picture";
            this.pic_Picture.Size = new System.Drawing.Size(130, 98);
            this.pic_Picture.TabIndex = 2;
            this.pic_Picture.TabStop = false;
            // 
            // frm_ExceptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 145);
            this.Controls.Add(this.pic_Picture);
            this.Controls.Add(this.lbl_ExceptionMessage);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ExceptionBox";
            this.Text = "frm_ExceptionBox";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_ExceptionMessage;
        private System.Windows.Forms.PictureBox pic_Picture;
    }
}