using CommandLine;
using System;
using System.Windows.Forms;

namespace SimpleNotification {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Options clArguments = new Options();
        public class Options {
            [Option(
                'm',
                "Message",
                Required = true,
                HelpText = "The message to display to the end user."
            )]
            public string Message { get; set; }

            [Option(
                'i',
                "ImageURL",
                Required = false,
                Default = "",
                HelpText = "The URL for the image to display instead of the default."
            )]
            public string ImageURL { get; set; }

            [Option(
                'e',
                "Email",
                Required = false,
                Default = "",
                HelpText = "The support e-mail address to display to the user."
            )]
            public string Email { get; set; }

            [Option(
                'p',
                "Phone",
                Required = false,
                Default = "",
                HelpText = "The support phone number to display to the user."
            )]
            public string Phone { get; set; }
        }

        [STAThread]
        static void Main(string[] args) {
            CommandLine.Parser.Default.ParseArguments<Options>(args).WithParsed((opts) => clArguments = opts).WithNotParsed((errs) => Environment.Exit(1));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(clArguments.Message, clArguments.ImageURL, clArguments.Email, clArguments.Phone));
        }
    }

}
