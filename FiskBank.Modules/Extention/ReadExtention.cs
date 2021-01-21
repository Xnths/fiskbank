using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FiskBank
{
    partial class Program
    {
        public static void ToOpenFile(string diretory)
        {
            var buffer = new byte[1024];
            var readedBytes = -1;

            using (var fileStream = new FileStream(diretory, FileMode.Open))
            {
                while (readedBytes != 0)
                {
                    readedBytes = fileStream.Read(buffer, 0, 1024);
                    ToReadBuffer(buffer, readedBytes);
                }
            }
        }

        public static void ToReadBuffer(byte[] buffer, int readedBytes)
        {
            var utf8 = Encoding.UTF8;
            Console.Write(utf8.GetString(buffer, 0, readedBytes));
        }

    }
}