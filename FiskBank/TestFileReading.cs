using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FiskBank
{
    partial class Program
    {
        public static void ToRegistryStudent()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Address: ");
            var streetName = Console.ReadLine();

            Console.Write("House's number: ");
            var houseNumber = Console.ReadLine();

            Console.Write("Neighborhood: ");
            var neighborhood = Console.ReadLine();

            Console.Write("City: ");
            var city = Console.ReadLine();

            Console.Write("Postal Code: ");
            var postalCode = Console.ReadLine();

            using(var fs = new FileStream("students.txt", FileMode.OpenOrCreate))
            using (var sw = new BinaryWriter(fs))
            {
                sw.Write(name);
                sw.Write(streetName);
                sw.Write(houseNumber);
                sw.Write(neighborhood);
                sw.Write(city);
                sw.Write(postalCode);
                
                sw.Flush();
            }
        }
        public static void ToReadFile()
        {
            using (var fs = new FileStream("students.txt", FileMode.Open))
            using (var binaryReader = new BinaryReader(fs))
            {
                var name = binaryReader.ReadString();
                var streetName = binaryReader.ReadString();
                var houseNumber = binaryReader.ReadString();
                var neighborhood = binaryReader.ReadString();
                var city = binaryReader.ReadString();
                var postalCode = binaryReader.ReadString();

                Console.Write($"{name},{streetName},{houseNumber},{city},{postalCode}");
            }

        }
        static void ToOpenFile(string diretory)
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