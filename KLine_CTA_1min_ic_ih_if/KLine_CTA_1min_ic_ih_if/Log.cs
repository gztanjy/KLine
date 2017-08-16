﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace KLine_CTA_1min_ic_ih_if
{
    class Log
    {
        Log()
        {
            if(!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }
        }

        public static void AppendALLText(string contents)
        {
            File.AppendAllText(@"Log.txt", contents);
        }

        public static void AppendAllLines(IEnumerable<string> contents)
        {
            try
            {
                File.AppendAllLines(@"Log.txt", contents);
            }
            catch(Exception)
            {
                Guid guid = Guid.NewGuid();
                File.AppendAllLines(@"Logs\Log" +guid.ToString()+ @".txt", contents);
            }

        }

        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            try
            {
                File.AppendAllLines(path, contents);
            }
            catch (Exception)
            {
                Guid guid = Guid.NewGuid();
                File.AppendAllLines(@"Logs\Log" + guid.ToString() + @".txt", contents);
            }

        }
    }
}