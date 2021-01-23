using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiskBank.Modules.Exceptions;
using FiskBank.Modules.Students;
using Interface.Helpers;

namespace UserInterface
{
    public partial class frm_StudentRegistration : Form
    {
        public frm_StudentRegistration()
        {
            InitializeComponent();
        }

        private void cb_ManualRegistry_CheckedChanged(object sender, EventArgs e)
        {
            msk_Registry.ReadOnly = !cb_ManualRegistry.Checked;
        }
        private void cb_Monitor_CheckedChanged(object sender, EventArgs e)
        {
            var discountValue = msk_Discount;
            var monitorDiscount = cb_Monitor.Checked;
            
            discountValue.ReadOnly = monitorDiscount;
            
            if (monitorDiscount)
            {
                discountValue.Mask = "000%";
                discountValue.Text = "100";
            }
            else
            {
                discountValue.Mask = "00%";
                discountValue.Text = "";
            }
        }
        private void btn_SubmitForm_Click(object sender, EventArgs e)
        {
            var name = txt_Name.Text;
            var password = txt_Password.Text;
            var registry = FixMaskFormatHelper.ConvertMaskToShort(msk_Registry);
            var discount = FixMaskFormatHelper.ConvertPercentageToDouble(msk_Discount);
            var streetName = txt_StreetName.Text;
            var houseNumber = msk_HouseNumber.Text;
            var neighborhood = txt_Neighborhood.Text;
            var city = txt_City.Text;
            var postalCode = msk_PostalCode.Text;

            Adult adult;

            var messageResponse = MessageBox.Show($"{name},{streetName},{houseNumber},{neighborhood},{city},{postalCode}.",
                "Confirm information", MessageBoxButtons.YesNo);

            if(messageResponse == DialogResult.Yes)
            {
                try
                {
                    if (cb_ManualRegistry.Checked)
                    {
                        adult = new Adult(name, password, registry, discount, streetName, houseNumber, neighborhood,
                            city, postalCode);
                    }
                    else
                    {
                        adult = new Adult(name, password, discount, streetName, houseNumber,
                            neighborhood, city, postalCode);
                    }

                    MessageBox.Show($"{adult.Name}, {adult.Address.StreetName},{adult.Address.Number},{adult.Address.Neighborhood},{adult.Address.City},{adult.Address.PostalCode}",
                    "Student Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(DuplicateRegistryException ex)
                {
                    MessageBox.Show(ex.Message, "Duplicate student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_StudentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
