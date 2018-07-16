using System;
using System.IO;

namespace RSSReportRetrievers.Services
{
    public class LogHandler
    {
        public static void WriteLogEntry(Exception ex)
        {
            using (var streamWriter1 = new StreamWriter("RSSExplorer.log", true))
            {
                for (; ex != null; ex = ex.InnerException)
                {
                    var streamWriter2 = streamWriter1;
                    var format1 = "{0} : {1}";
                    var now = DateTime.Now;
                    var str1 = now.ToString("dd-MM-yyyy HH:mm");
                    var message = ex.Message;
                    var str2 = string.Format(format1, str1, message);
                    streamWriter2.WriteLine(str2);
                    var streamWriter3 = streamWriter1;
                    var format2 = "{0} : {1}";
                    now = DateTime.Now;
                    var str3 = now.ToString("dd-MM-yyyy HH:mm");
                    var stackTrace = ex.StackTrace;
                    var str4 = string.Format(format2, str3, stackTrace);
                    streamWriter3.WriteLine(str4);
                }
            }
        }

        public static void WriteLogEntry(Exception ex, string message)
        {
            WriteLogEntry(message);
            WriteLogEntry(ex);
        }

        public static void WriteLogEntry(string message)
        {
            using (var streamWriter = new StreamWriter("RSSExplorer.log", true))
            {
                streamWriter.WriteLine("{0} : {1}", DateTime.Now.ToString("dd-MM-yyyy HH:mm"), message);
            }
        }
    }
}