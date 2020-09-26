using System;
using System.IO;
using System.Text;

namespace CSharpSts
{
    public class SaveFile
    {
    public void Main()
    {
        string path = @"directory/Mytext.txt";

        // Create the file, or overwrite if the file exists.
        using (FileStream fs = File.Create(path, 1024))
        {
            byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

        // Open the stream and read it back.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    }
}