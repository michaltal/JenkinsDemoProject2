//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDemoProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            //using (FileStream fs = File.Create(path))
            //{
            //    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            //    // Add some information to the file.
            //    fs.Write(info, 0, info.Length);
            //}


            //squareroot.square_root(16.0);
        }
    }

    public class squareroot
    {
        private const string Path = @"C:\Jenkins\Res.txt";

        public
        double square_root(double a)
        {
            double dblRes = 0;

            if (a < 0)
            {
                return -1;
            }
            else
            {
                Console.WriteLine(Math.Sqrt(a));
                dblRes = Math.Sqrt(a);
                return dblRes;
            }
        }

        public
        void LogToFile(double inp)
        {
            using (System.IO.StreamWriter file =
            new StreamWriter(Path, append: true))
            {
                //file.WriteLine(inp.ToString());
                file.WriteLine(inp);
            }
        }

        public
        void ClearFile(string file_path)
        {
            using (var fs = new FileStream(file_path, FileMode.Truncate))
            {
            }
        }
    }
}
