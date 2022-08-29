using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public sealed class Log : Ilog
    {
        private Log() 
        {

        }

        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void Logexception(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", "fechadehoy");
            string logFilePath = string.Format(@"{0}\{1}", "C:\\Test", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
