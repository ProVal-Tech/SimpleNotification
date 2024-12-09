using CommandLine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Tomlyn;

namespace SimpleNotification {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public class Options {
            [Option(
                'm',
                "message",
                Required = true,
                HelpText = "The message to display to the end user.",
                SetName = "direct"
            )]
            public string Message { get; set; }

            [Option(
                'i',
                "imageurl",
                Required = false,
                Default = "",
                HelpText = "The URL for the image to display instead of the default.",
                SetName = "direct"
            )]
            public string ImageUrl { get; set; }

            [Option(
                'e',
                "email",
                Required = false,
                Default = "",
                HelpText = "The support e-mail address to display to the user.",
                SetName = "direct"
            )]
            public string Email { get; set; }

            [Option(
                'p',
                "phone",
                Required = false,
                Default = "",
                HelpText = "The support phone number to display to the user.",
                SetName = "direct"
            )]
            public string Phone { get; set; }
            
            [Option(
                'c',
                "configfile",
                Required = true,
                Default = "",
                HelpText = "The path to the TOML config file.",
                SetName = "toml"
            )]
            [IgnoreDataMember]
            public string TomlPath { get; set; }
        }

        private static Options clArguments = new Options();

        [STAThread]
        static void Main(string[] args) {
            Parser parser = new Parser(settings => { settings.CaseSensitive = false; });
            parser.ParseArguments<Options>(args)
                .WithParsed((opts) => clArguments = opts)
                .WithNotParsed((errs) => Environment.Exit(1));
            if (!string.IsNullOrWhiteSpace(clArguments.TomlPath)) {
                try {
                    string toml = File.ReadAllText(clArguments.TomlPath);
                    clArguments = Toml.ToModel<Options>(toml);
                } catch {
                    Console.WriteLine("Error reading TOML file.");
                    Environment.Exit(1);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(clArguments.Message, clArguments.ImageUrl, clArguments.Email, clArguments.Phone));
        }
    }

}
