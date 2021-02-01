using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frm_StaffRegistration_UC : UserControl
    {
        public frm_StaffRegistration_UC()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png) |*.jpg; *.jpeg; *.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pic_ProfilePicture.Image = Image.FromFile(open.FileName);
            }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_StaffRegistration.Text = $"{txt_Name.Text}'s Registration";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var db = new frm_ConfirmationBox(
                "Are you sure about the information?",
                $"Name : {txt_Name.Text}",
                $"Id: {txt_Id.Text}",
                pic_ProfilePicture.Image);
            if(db.ShowDialog() == DialogResult.Yes)
            {
                var mb = MessageBox.Show(
                    "Successfully registred",
                    "Registred",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
