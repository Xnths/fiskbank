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
    public partial class frm_ExceptionBox : Form
    {
        public frm_ExceptionBox(string title, string message, string imageName)
        {
            InitializeComponent();

            Image image = (Image)global::Interface.Properties.Resources.ResourceManager.GetObject(imageName);

            lbl_Title.Text = title;
            lbl_ExceptionMessage.Text = message;
            pic_Picture.Image = image;
        }
    }
}
