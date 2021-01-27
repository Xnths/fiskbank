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
            var chooseFile = new OpenFileDialog();
            var profilePicture = pic_ProfilePicture;

            var fileName = chooseFile.FileName;

            profilePicture.Image = Image.FromFile(fileName);
        }
    }
}
