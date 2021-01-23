using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Helpers
{
    class FixMaskFormatHelper
    {
        internal static short ConvertMaskToShort(MaskedTextBox mask)
        {
            if (mask.Text == "") return 0;
            var maskString = mask.Text.Replace(" ", "").Trim();
            return Int16.Parse(maskString);
        }
        internal static double ConvertPercentageToDouble(MaskedTextBox percentageMask)
        {
            var percentageString = percentageMask.Text.Replace(" ", "").Replace("%", "").Trim();
            //Position 2 in the array correspond to %
            return Int64.Parse(percentageString);
        } 
    }
}
