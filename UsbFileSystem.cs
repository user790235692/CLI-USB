namespace CSharpSts
{
    public class UsbFileSystem
    {
        public string FileSystem {get; set;}

        public UsbFileSystem(string FileSystem)
        {
            this.FileSystem = FileSystem;
        }

        public override string ToString()
        {
            return $"{FileSystem}";
        }
    }
}