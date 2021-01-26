using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface;

namespace Interface
{
    public partial class frm_MainMDI : Form
    {
        static int iSR = 1;
        static int iPAS = 1;
        public frm_MainMDI()
        {
            InitializeComponent();
        }

        private void studentRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_StudentRegistration_UC();
            var tb = new TabPage();

            tb.Name = "Student Registration";
            if(iSR == 1)
            {
                tb.Text = "Student Registration";
            }
            else
            {
                tb.Text = $"Student Registration {iSR}";
            }
            tb.Controls.Add(f);

            tbc_Terminal.TabPages.Add(tb);
            iSR++;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbc_Terminal.SelectedTab == null) return;
            tbc_Terminal.TabPages.Remove(tbc_Terminal.SelectedTab);
        }

        private void pedagogicalAdministrationSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_PedagogicalAdministrationSystem_UC();
            var tb = new TabPage();
            
            tb.Name = "Pedagogical Administration System";
            
            if(iPAS == 1)
            {
                tb.Text = "Pedagogical Administration System";
            }
            else
            {
                tb.Text = $"Pedagogical Administration System {iPAS}";
            }
            tb.Controls.Add(f);

            tbc_Terminal.TabPages.Add(tb);
            iPAS++;
        }
    }
}
