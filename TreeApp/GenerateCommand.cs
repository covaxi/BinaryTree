using ManyConsole;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class GenerateCommand : ConsoleCommand
    {
        string FileName { get; set; }

        public GenerateCommand()
        {
            IsCommand("generate", "Generate a random tree and save it to the file");

            HasRequiredOption("f|file=", "The file to use", a => FileName = a);
        }

        public override int Run(string[] remainingArguments)
        {
            try
            {
                Console.WriteLine();
                using (var stream = File.OpenWrite(FileName))
                {
                    var tree = Helpers.GenerateTree();
                    Helpers.ShowTree(tree);
                    Helpers.Service.Save(stream, tree);
                    Console.WriteLine();
                    Console.WriteLine($"Tree has been writter to '{FileName}'");
                }
                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
