using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using System.Drawing;

namespace QR_code_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This code is QR Code Generated

            var qrcode_writer = new BarcodeWriter();
            qrcode_writer.Format = BarcodeFormat.QR_CODE;
            qrcode_writer.Write("http://www.google.com").Save(@"E:\C#\QR Code in C sharp\QR_Code_Generated.bmp");
            Console.WriteLine("QR Code is Generated.");
            Console.WriteLine();
            Console.WriteLine();

            //This code is Read the QR Code

            var qrcode_bitmap = (Bitmap)Bitmap.FromFile(@"E:\C#\QR Code in C sharp\QR_Code_Generated.bmp");
            var qrcode_reader = new BarcodeReader();
            var qrcode_result = qrcode_reader.Decode(qrcode_bitmap);

            Console.WriteLine($"Decode Barcode text: {qrcode_result.Text}");
            Console.WriteLine($"Barcode Format: {qrcode_result.BarcodeFormat}");
            Console.WriteLine("QR Code Successfully Readed!");
            Console.ReadLine();


        }
    }
}
