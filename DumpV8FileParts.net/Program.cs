using Fclp;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.IO;
using v8file.net;

namespace DumpV8FileParts.net
{
    public class ApplicationArguments
    {
        public bool Help { get; set; }
        public string ElementType { get; set; }
        public string FileName { get; set; }
        public string OutDir { get; set; }
        public string ElementId { get; set; }
        public string LevelId { get; set; }
    }

    static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static void InitLogger()
        {
            // Step 1. Create configuration object 
            var config = new LoggingConfiguration();

            // Step 2. Create targets and add them to the configuration 
            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            // Step 3. Set target properties 
            fileTarget.FileName = "${specialfolder:folder=CommonApplicationData}/xWare/DumpV8FileAttributes.net/DumpV8FileAttributes.net_${shortdate}.log";
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

            parser.Setup(arg => arg.OutDir)
               .As('o', "outdir")
               .WithDescription("Specifies the output directory.")
               .Required();

            parser.Setup(arg => arg.ElementType)
               .As('t', "type")
               .WithDescription("Specifies the element type.")
               .SetDefault("-1");

            parser.Setup(arg => arg.ElementId)
               .As('e', "eid")
               .WithDescription("Specifies the element id.")
               .SetDefault("*");

            parser.Setup(arg => arg.LevelId)
               .As('l', "lid")
               .WithDescription("Specifies the level id.")
               .SetDefault("*");

            parser.SetupHelp("?", "h", "help")
               .WithHeader("Usage is: DumpV8FileAttributes.net -f fileName -o outputDir [-t elementType] [-e elementId] [-l levelId] ...")
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

                    if (!Directory.Exists(parser.Object.OutDir))
                    {
                        Directory.CreateDirectory(parser.Object.OutDir);
                    }

                    V8FileOLEStorage.V8DgnGetProperties();
                    V8FileManipulation.V8DgnLoad(parser.Object.FileName);

                    if (parser.Object.ElementType != "-1" && parser.Object.LevelId != "*")
                    {
                        // DumpV8FileAttributes.net -f fileName -o outputDir -t elementType -l levelId extracts element of type elementType on level levelId information parts
                        // eg: -f "n:\temp\dgns\Animation.dgn" -o "n:\temp\outdir" -t 5 -l 3 (extract ACS information)
                        V8FileManipulation.V8DgnParse(parser.Object.ElementType, parser.Object.ElementId, parser.Object.LevelId);
                    }
                    else if (parser.Object.ElementType != "-1" && parser.Object.ElementId != "*")
                    {
                        // DumpV8FileAttributes.net -f fileName -o outputDir -t elementType -e elementId extracts element of type elementType with elementId information parts
                        // elementid must be given in hex (upper case, 16 chars)
                        // we use it rarely !!!!!!!!!
                        // eg: -f "n:\temp\dgns\Animation.dgn" -o "n:\temp\outdir" -t 95 -e 0000000000000180
                        V8FileManipulation.V8DgnParse(parser.Object.ElementType, parser.Object.ElementId);
                    }
                    else if (parser.Object.LevelId == "*" && parser.Object.ElementId == "*")
                    {
                        // DumpV8FileAttributes.net -f fileName -o outputDir extracts model information parts (elementType is -1)
                        // eg: -f "n:\temp\dgns\Animation.dgn" -o "n:\temp\outdir" (get all model infos)
                        // DumpV8FileAttributes.net -f fileName -o outputDir -t elementType extracts element of type elementType information parts
                        // eg: -f "n:\temp\dgns\Animation.dgn" -o "n:\temp\outdir" -t 4 (get all line string infos)
                        V8FileManipulation.V8DgnParse(parser.Object.ElementType);
                    }
                }
                catch (Exception e)
                {
                    Logger.Error($"{e.Message}\r\n{e.StackTrace}");
                }
                finally
                {
                    /// move parts
                    V8FileManipulation.V8DgnMoveAll(parser.Object.OutDir);
                    // (move and) release resources
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
