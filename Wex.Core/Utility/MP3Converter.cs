using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WexOne.Core.AzureStorage;

namespace WexOne.Core.Utility
{
    public class MP3Converter
    {
        public const string exe_path = "~/ffmpeg/ffmpeg.exe";

        public static Task<string> ConvertToMP3(string originUrl)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = System.Web.HttpContext.Current.Server.MapPath(exe_path);
            
            string filename=Path.GetFileNameWithoutExtension(originUrl);
            string mp3_path = System.Web.HttpContext.Current.Server.MapPath("~/mp3/")+filename + ".mp3";
            psi.Arguments = string.Format(@"-i ""{0}"" -y ""{1}""", originUrl, mp3_path);
            psi.CreateNoWindow = true;
            psi.ErrorDialog = false;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = false;
            psi.RedirectStandardError = true;
            Process exeProcess = Process.Start(psi);
            exeProcess.PriorityClass = ProcessPriorityClass.High;
            string outString = string.Empty;
            exeProcess.OutputDataReceived += (s, e) =>
            {
                outString += e.Data;
            };
            exeProcess.BeginOutputReadLine();
            string errString = exeProcess.StandardError.ReadToEnd();

            exeProcess.WaitForExit();

            var stream  = File.OpenRead(mp3_path);

            AzureBlobStorageProvider provider = new AzureBlobStorageProvider("mp3");
            var url = provider.Save(stream, ".mp3");
            return url;
        }
    }
}