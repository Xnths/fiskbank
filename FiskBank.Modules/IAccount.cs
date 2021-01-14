using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public interface IAccount
    {
        /// <summary>
        /// Return income for balance in account.
        /// </summary>
        /// <returns></returns>
        double GetGain();
    }
}
