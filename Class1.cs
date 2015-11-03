using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka1
{
    public class HTTPFileDownloader
    {
        private WebClient webClient;
        public HTTPFileDownloader()
        {
            webClient = new WebClient();
        }

        public void DownloadFile(string address, string filename)
        {
            webClient.DownloadFile(address, filename);
        }
    }

    public class ZipManager
    {
        public void CompressToZip(string startPath, string zipPath)
        {
            ZipFile.CreateFromDirectory(startPath, zipPath);
        }

        public void ExctractFromZip(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);

        }
    }
}
