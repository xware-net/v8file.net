using Fclp;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.IO;
using v8file.net;

namespace DumpV8File.net
{
    public class ApplicationArguments
    {
        public bool Help { get; set; }
        public string ElementType { get; set; }
        public string FileName { get; set; }
        public string DumpFileName { get; set; }
        public string OutDir { get; set; }
        public string ElementId { get; set; }
        public string LevelId { get; set; }
    }

    class Program
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        private static void InitLogger()
        {
            // Step 1. Create configuration object 
            var config = new LoggingConfiguration();

            // Step 2. Create targets and add them to the configuration 
            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            // Step 3. Set target properties 
            fileTarget.FileName = "${specialfolder:folder=CommonApplicationData}/xWare/DumpV8File.net/DumpV8File.net_${shortdate}.log";
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

            var parser = new FluentCommandLineParser<ApplicationArguments>();

            parser.Setup(arg => arg.FileName)
               .As('f', "file")
               .WithDescription("Specifies the file name.")
               .Required();

            parser.Setup(arg => arg.DumpFileName)
               .As('d', "dumpfile")
               .WithDescription("Specifies the dump file name.")
               .Required();

            parser.Setup(arg => arg.OutDir)
               .As('o', "outdir")
               .WithDescription("Specifies the output directory.")
               .Required();

            parser.SetupHelp("?", "h", "help")
               .WithHeader("Usage is: DumpV8File.net -f fileName -o outputDir -d dumpFileName ...")
               .Callback(text => Console.WriteLine(text));

            var result = parser.Parse(args);

            if (result.HasErrors == false)
            {
                try
                {
                    if (!File.Exists(parser.Object.FileName))
                    {
                        Console.WriteLine($"File {parser.Object.FileName} not found. Exit...");
                        return -3;
                    }

                    if (V8FileOLEStorage.V8DgnBreak(parser.Object.FileName) != V8FileOLEStorage.MSuccess)
                    {
                        Console.WriteLine("{parser.Object.FileName} is not a V8 dgn file. Exit...");
                        return -2;
                    }

                    V8FileOLEStorage.V8DgnGetProperties(parser.Object.FileName);
                    V8FileManipulation.V8DgnLoad(parser.Object.FileName);
                    if (!string.IsNullOrEmpty(parser.Object.DumpFileName) && !string.IsNullOrEmpty(parser.Object.OutDir))
                    {
                        var outFileName = Path.Combine(parser.Object.OutDir, Path.GetFileName(parser.Object.DumpFileName));
                        using StreamWriter sw = new(outFileName);
                        V8FileManipulation.V8DgnParse(sw);
                    }
                }
                catch (Exception e)
                {
                    Logger.Error($"{e.Message}\r\n{e.StackTrace}");
                }
                finally
                {
                    V8FileManipulation.V8DgnFreeAll(parser.Object.OutDir);
                }

                return 0;
            }
            else
            {
                parser.HelpOption.ShowHelp(parser.Options);
                return -1;
            }
        }
    }
}
