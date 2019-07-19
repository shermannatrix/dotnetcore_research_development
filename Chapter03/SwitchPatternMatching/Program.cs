using System;
using System.IO;
using static System.Console;

namespace SwitchPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/thecxhacker/research-development/" +
                "dotnetcore_research_development/Chapter03/SwitchPatternMatching";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            switch(s) {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default:
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }
        }
    }
}
