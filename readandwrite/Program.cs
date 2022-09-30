using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readandwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //...get the file path...//
            string filepath = @"..\..\..\file.txt";
            //...read all character..//
            string path = File.ReadAllText(filepath);
            Console.WriteLine(path);
            //....count of word....//
            int word = 0;
            for(int i=0;i<path.Length;i++)
            {
                if (path[i] == ' ' || path[i] == '\n')
                    word++;
            }
            Console.WriteLine("total word - " + word);

            //....name and extensition of text file...//
            FileInfo name = new FileInfo(filepath);
            string fname = name.Name;
            string fextension = name.Extension;
            Console.WriteLine("file name - " + fname);
            Console.WriteLine("file extension - " + fextension);
            //....copy of text file in to another drive...//
            string destination = @"..\..\..\file1.txt";
            File.Copy(filepath, destination, true);
            //....delete file....//
            File.Delete(@"..\..\..\file1.txt");
            //....Copy text file from another folder where you copied....\\
            File.Copy(filepath, destination, true);


        }
    }
}
