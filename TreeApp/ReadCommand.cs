using BinaryTree;
using ManyConsole;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    public class ReadCommand : ConsoleCommand
    {
        string FileName { get; set; }

        public ReadCommand()
        {
            IsCommand("load", "Load a tree from the file");

            HasRequiredOption("f|file=", "Load tree from file and show", a => FileName = a);
        }

        public override int Run(string[] remainingArguments)
        {
            try
            {
                var service = TreeService.Get<int>();
                Console.WriteLine();
                Console.WriteLine($"Reading a tree from '{FileName}");
                using (var stream = File.OpenRead(FileName))
                {
                    Helpers.ShowTree(service.Load(stream));
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
