using FiskBank.Modules;
using FiskBank.Modules.Accounts;
using FiskBank.Modules.Staff;
using FiskBank.Modules.Students;
using FiskBank.Modules.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FiskBank
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ToRegistryStudent();
            ToReadFile();
            Console.ReadLine();
        }

    }
}
