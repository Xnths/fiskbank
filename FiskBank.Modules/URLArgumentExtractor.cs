using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FiskBank.Modules
{
    public class URLArgumentExtractor
    {
        private readonly string _url;
        private readonly int _index;

        //fiskbank?fromCurrency=bit&toCurrency=fiskdollar
        public URLArgumentExtractor(string url)
        {
            String.IsNullOrEmpty(url);
            _index = url.IndexOf('?');
            _url = url.Substring(_index + 1);
        }

        /// <summary>
        /// Returns argument especified on instanced object.
        /// </summary>
        /// <param name="paramName">Parameter's name to be extracted by method.</param>
        /// <returns></returns>
        public string GetArgument(string paramName)
        {
            string urlUpper = _url.ToUpper();

            string parameter = (paramName + "=").ToUpper();
            int argumentIndex = urlUpper.IndexOf(parameter) + parameter.Length;

            string argumentTrimmed = _url.Substring(argumentIndex);
            int removeIndex = argumentTrimmed.IndexOf('&');

            if (removeIndex == -1) return argumentTrimmed;

            return argumentTrimmed.Remove(removeIndex);
        }
        /// <summary>
        /// Returns Phone Number.
        /// </summary>
        /// <returns></returns>
        public string GetPhoneNumber()
        {
            string pattern = "[1-9][0-9]{3}-?[0-9]{4}";
            if (!Regex.IsMatch(_url, pattern)) return "There is no phone number specified." ;
            return Regex.Match(_url, pattern).Value;
        }

        /// <summary>
        /// Returns Id.
        /// </summary>
        /// <returns></returns>
        public string GetId()
        {
            string pattern = "[1-9][0-9].?[0-9]{3}[0-9]{3}-?[x123456789]";
            if(Regex.IsMatch(_url, pattern)) return "There is no id.";
            return Regex.Match(_url, pattern).Value;
        }
    }
}
