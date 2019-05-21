using System;
using System.IO;
using System.Windows.Forms;

namespace DTPKutil
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //Note: This console output won't actually print to the console because it's a desktop app.
                //It can be fixed, but this is a bonus feature anyway so just use it correctly.
                Console.WriteLine("DTPKUtil Command Line");
                if(args[0].Equals("/?") || args[0].Equals("-help"))
                {
                    Console.WriteLine("  -help These instructions");
                    Console.WriteLine("  -decompress <inputFile> <outputFile>");
                    Console.WriteLine("      Decompress a .SND file normally.");
                    Console.WriteLine("  -decompress32 <inputFile> <outputFile>");
                    Console.WriteLine("      Decompress a .SND file and expand all samples to 32 bit.");
                    return;
                }
                if(args.Length >= 3)
                {
                    if (args[0].Equals("-decompress") && args.Length == 3)
                    {
                        try
                        {
                            if (File.Exists(args[1]))
                            {
                                DtpkFile file = new DtpkFile(File.ReadAllBytes(args[1]));
                                file = file.Decompress(false);
                                File.WriteAllBytes(args[2], file.FileData);
                                Console.WriteLine("File decompressed successfully");
                                return;
                            }
                        }
                        finally
                        {
                            Console.WriteLine("Bad file specified");
                        }
                    }
                    else if (args[0].Equals("-decompress32") && args.Length == 3)
                    {
                        try
                        {
                            if (File.Exists(args[1]))
                            {
                                DtpkFile file = new DtpkFile(File.ReadAllBytes(args[1]));
                                file = file.Decompress(true);
                                File.WriteAllBytes(args[2], file.FileData);
                                Console.WriteLine("File decompressed successfully");
                                return;
                            }
                        }
                        finally
                        {
                            Console.WriteLine("Bad file specified");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Launched with unexpected arguments. Use -help for instructions");
                    }
                    return;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

    }
}
