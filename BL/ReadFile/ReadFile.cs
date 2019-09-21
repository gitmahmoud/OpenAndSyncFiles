using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace BL
{
    public class ReadFile : IReadFile
    {
        public byte[] DownloadFile(string url)
        {

            string fileName = DownloadOndisk(url);
            if (string.IsNullOrEmpty(fileName))
                return null;

            //convert file to byteArray
            return ConvertFileToByteArray(fileName);
        }

        private string DownloadOndisk(string url)
        {
            try
            {
                //"https://image-us.samsung.com/SamsungUS/home/home-appliances/dishwashers/rotary/pd/dw80r9950ug-aa/newspecsheet/DW80R9950US_V6.pdf"
                WebClient client = new WebClient();
                Guid guid = new Guid();
                string fileName = guid.ToString();

                client.DownloadFile(url, @"d:\" + fileName + ".pdf");
                return fileName;
            }
            catch
            {
                return string.Empty;
            }
        }

        private byte[] ConvertFileToByteArray(string fileName)
        {
            try
            {
                return System.IO.File.ReadAllBytes(@"d:\" + fileName + ".pdf");
            }
            catch
            {
                return null;
            }
        }
    }
}
