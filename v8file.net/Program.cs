using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.IO;

namespace v8file.net
{
    class Program
    {
        private static void InitLogger()
        {
            // Step 1. Create configuration object 
            var config = new LoggingConfiguration();

            // Step 2. Create targets and add them to the configuration 
            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            // Step 3. Set target properties 
            fileTarget.FileName = "${specialfolder:folder=CommonApplicationData}/xWare/v8file.net/v8file.net_${shortdate}.log";
            fileTarget.CreateDirs = true;

            // Step 4. Define rules
            var rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);

            // Step 5. Activate the configuration
            LogManager.Configuration = config;
        }


        static int Main(string[] args)
        {
            InitLogger();

            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("Usage is: v8file.net dgnfilename [outfile] [saveToDir]. Exit...");
                return -1;
            }

            try
            {
                if (V8FileOLEStorage.V8DgnBreak(args[0]) != V8FileOLEStorage.MSuccess)
                {
                    Console.WriteLine("Not a V8 dgn file. Exit...");
                    return -2;
                }

                V8FileOLEStorage.V8DgnGetProperties(args[0]);
                V8FileManipulation.V8DgnLoad(args[0]);
                if (args.Length == 3)
                {
                    using StreamWriter sw = new(args[1]);
                    V8FileManipulation.V8DgnParse(sw, Convert.ToBoolean(args[2]));
                }
                else if (args.Length == 2)
                {
                    using StreamWriter sw = new(args[1]);
                    V8FileManipulation.V8DgnParse(sw);
                }
                else if (args.Length == 1)
                {
                    using StreamWriter sw = new(Console.OpenStandardOutput());
                    sw.AutoFlush = true;
                    Console.SetOut(sw);
                    V8FileManipulation.V8DgnParse(sw);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                V8FileManipulation.V8DgnFreeAll();
            }

            return 0;
        }
    }
}
