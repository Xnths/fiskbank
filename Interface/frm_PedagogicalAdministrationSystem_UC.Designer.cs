
namespace Interface
{
    partial class frm_PedagogicalAdministrationSystem_UC
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
            this.lbl_PedagogicalAdministrationSystem = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Report = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dtp_Timer = new System.Windows.Forms.DateTimePicker();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_ViewReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PedagogicalAdministrationSystem
            // 
            this.lbl_PedagogicalAdministrationSystem.AutoSize = true;
            this.lbl_PedagogicalAdministrationSystem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PedagogicalAdministrationSystem.Location = new System.Drawing.Point(13, 11);
            this.lbl_PedagogicalAdministrationSystem.Name = "lbl_PedagogicalAdministrationSystem";
            this.lbl_PedagogicalAdministrationSystem.Size = new System.Drawing.Size(317, 23);
            this.lbl_PedagogicalAdministrationSystem.TabIndex = 0;
            this.lbl_PedagogicalAdministrationSystem.Text = "Pedagogical Administration System";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(18, 52);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(18, 78);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Date:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(57, 75);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(80, 20);
            this.dtp_Date.TabIndex = 4;
            this.dtp_Date.Value = new System.DateTime(2021, 1, 26, 11, 51, 53, 0);
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.Location = new System.Drawing.Point(18, 104);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(42, 13);
            this.lbl_Report.TabIndex = 5;
            this.lbl_Report.Text = "Report:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(384, 185);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // dtp_Timer
            // 
            this.dtp_Timer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Timer.Location = new System.Drawing.Point(187, 75);
            this.dtp_Timer.Name = "dtp_Timer";
            this.dtp_Timer.Size = new System.Drawing.Size(65, 20);
            this.dtp_Timer.TabIndex = 8;
            this.dtp_Timer.Value = new System.DateTime(2021, 1, 26, 11, 51, 53, 0);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(148, 78);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.lbl_Time.TabIndex = 7;
            this.lbl_Time.Text = "Time:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(411, 328);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_ViewReports
            // 
            this.btn_ViewReports.Location = new System.Drawing.Point(359, 11);
            this.btn_ViewReports.Name = "btn_ViewReports";
            this.btn_ViewReports.Size = new System.Drawing.Size(127, 23);
            this.btn_ViewReports.TabIndex = 10;
            this.btn_ViewReports.Text = "View Reports ";
            this.btn_ViewReports.UseVisualStyleBackColor = true;
            // 
            // frm_PedagogicalAdministrationSystem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ViewReports);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dtp_Timer);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_Report);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_PedagogicalAdministrationSystem);
            this.Name = "frm_PedagogicalAdministrationSystem_UC";
            this.Size = new System.Drawing.Size(489, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PedagogicalAdministrationSystem;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Report;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dtp_Timer;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ViewReports;
    }
}
