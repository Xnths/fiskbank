
namespace Interface
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SubmitForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(40, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_ApplicationName
            // 
            this.lbl_ApplicationName.AutoSize = true;
            this.lbl_ApplicationName.Font = new System.Drawing.Font("Roboto Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplicationName.Location = new System.Drawing.Point(13, 13);
            this.lbl_ApplicationName.Name = "lbl_ApplicationName";
            this.lbl_ApplicationName.Size = new System.Drawing.Size(102, 27);
            this.lbl_ApplicationName.TabIndex = 1;
            this.lbl_ApplicationName.Text = "FiskBank";
            this.lbl_ApplicationName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_SubmitForm
            // 
            this.btn_SubmitForm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitForm.Location = new System.Drawing.Point(713, 415);
            this.btn_SubmitForm.Name = "btn_SubmitForm";
            this.btn_SubmitForm.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitForm.TabIndex = 3;
            this.btn_SubmitForm.Text = "Submit";
            this.btn_SubmitForm.UseVisualStyleBackColor = true;
            this.btn_SubmitForm.Click += new System.EventHandler(this.btn_SubmitForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SubmitForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_ApplicationName);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ApplicationName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SubmitForm;
    }
}

