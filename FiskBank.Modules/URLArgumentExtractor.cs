using System;
using System.Collections.Generic;
using System.Text;

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
        /// <param name="paramName">Parameter's name to be extracted by the method.</param>
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
    }
}
