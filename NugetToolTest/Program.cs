using System;

namespace NugetToolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine($"Wanted 1 parameter got {args.Length} ({string.Join(", ", args)})");
                return;
            }

            var x = new ICSharpCode.SharpZipLib.Zip.FastZip();

            var file = new System.IO.FileInfo(args[0]);
            if (!file.Exists)
            {
                Console.WriteLine($"File {file.FullName} does not exists");
                return;
            }

            var content = System.IO.File.ReadAllText(file.FullName);

            Console.WriteLine(content + x.ToString());
        }
    }
}
