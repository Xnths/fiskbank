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
    public partial class frm_ConfirmationBox : Form
    {
        public frm_ConfirmationBox(string title, string name, string id, Image image)
        {
            InitializeComponent();

            lbl_Title.Text = title;
            lbl_Name.Text = name;
            lbl_Id.Text = id;
            pic_ProfileImage.Image = image;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
