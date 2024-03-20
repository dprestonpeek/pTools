using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ImageScrambler
{
    public class FileDownload
    {
        public static bool DownloadComplete { get { return downloadProcess.IsCompleted; } set { } }

        private static Task downloadProcess;
        public static void DownloadImageToFile(string url, string filename)
        {
            string[] urlSplit = url.Split('/');
            if (filename == "")
            {
                filename = urlSplit[urlSplit.Length - 1];
            }
            while (File.Exists(filename))
            {
                Match match = Regex.Match(filename, "[_]\\d+[.]\\D+");
                if (match.Success)
                {
                    string[] filenameSplit = filename.Split('.');
                    string filenameEnd = "." + filenameSplit[filenameSplit.Length - 1];
                    string[] indexSplit = filename.Split('_');
                    string indexStr = indexSplit[indexSplit.Length - 1];
                    int indexStrIndex = indexStr.IndexOf(filenameEnd);
                    int filenameIndex = filename.IndexOf(filenameEnd);
                    indexStr = indexStr.Substring(0, indexStrIndex);
                    filename = filename.Substring(0, filenameIndex - 1);
                    int index = int.Parse(indexStr);
                    index++;
                    indexStr = index.ToString();
                    filename += indexStr + filenameEnd;
                }
                else
                {
                    string[] filenameSplit = filename.Split('.');
                    string filenameEnd = "." + filenameSplit[filenameSplit.Length - 1];
                    filename = filename.Substring(0, filename.IndexOf(filenameEnd));
                    filename += "_1" + filenameEnd;
                }
            }
            using (var client = new WebClient())
            {
                downloadProcess = client.DownloadFileTaskAsync(url, filename);
            }
        }
    }
}
