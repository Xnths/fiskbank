﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Helpers
{
    internal class LogHelper
    {
        public static string Log(string message)
        {
            return $"{DateHelper.DateToString(DateTime.Now)} -> {message}";
        }
    }
}
