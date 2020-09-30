using System;
using System.Collections.Generic;

namespace CSharpSts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer une clé usb !");

            string valueInputGo = Console.ReadLine();

            try
            {
                FetchUSB(Int32.Parse(valueInputGo));
            }

            catch(FormatException)
            {
                Console.WriteLine("Rentrez seulement des chiffres !");
            }

            IsPlugIn();

            Console.WriteLine("Dans quel formatage voulez-vous votre usb ?");

            string valueInputSystem = Console.ReadLine().ToUpper();

            try
            {
                FormatUsb(valueInputSystem);
            }

            catch(FormatException)
            {
                Console.WriteLine("Rentrz seulement des caractère !");
            }

            SaveFile saveFile = new SaveFile();

            saveFile.Main();

            

        }
        public static List<Usb> CreateUSB() {
            List<Usb> usbCapacity = new List<Usb>();
            
            usbCapacity.Add(new Usb(4, 1073741824));
            usbCapacity.Add(new Usb(8, 8589934592));
            usbCapacity.Add(new Usb(16, 17179869184));
            usbCapacity.Add(new Usb(32, 34359738368));
            usbCapacity.Add(new Usb(64, 68719476736));
            usbCapacity.Add(new Usb(128, 137438953472));
            usbCapacity.Add(new Usb(256, 274877906944));
            usbCapacity.Add(new Usb(512, 549755813888));

            return usbCapacity;

        }
        public static void FetchUSB(int RealCapacityGo)
        {
            List<Usb> usb_keys = CreateUSB();

            bool IsGood = false;

            foreach(var usbCapacity in usb_keys)
            {   
                
                if (usbCapacity.RealCapacityGo == RealCapacityGo)
                {
                    IsGood = true;

                    Console.WriteLine($"USB trouvé : {usbCapacity}");
                }
            }

            foreach(var usbCapacity in usb_keys)
            {
                if (!IsGood)
                {
                Console.WriteLine($"Usb non trouvé, veuillez entrer une capcité valide {usbCapacity}");
                }   
            } 
                   
        }

        public static List<UsbFileSystem> InitializeUsb()
        {
            List<UsbFileSystem> usbFileSystem = new List<UsbFileSystem>();

            usbFileSystem.Add(new UsbFileSystem ("NTFS"));
            usbFileSystem.Add(new UsbFileSystem ("FAT32"));
            usbFileSystem.Add(new UsbFileSystem ("EXFAT"));

            return usbFileSystem;
        }

        public static void FormatUsb(string FileSystem)
        {
            List<UsbFileSystem> usb_files = InitializeUsb();

            bool isFormated = false;

            foreach(var UsbFileSystem in usb_files)
            {
                if (UsbFileSystem.FileSystem == FileSystem)
                    {

                    isFormated = true;

                    Console.WriteLine($"Votre usb est formaté au sytème: {UsbFileSystem}");

                    var result = Console.ReadLine();
                    } 
            }

            foreach(var UsbFileSystem in usb_files)
            {
                if(!isFormated)
                {
                    Console.WriteLine($"Voci les formatages disponibles: {UsbFileSystem}");
                }
            }


        }

        public static void IsPlugIn()
        {
            IsPlug isPlug = new IsPlug();

            Console.WriteLine("voulez-vous insérer la clé USB ? (yes or no)");

            var result = isPlug.getBoolInputValue(Console.ReadLine());

            Console.WriteLine(result);
        }
    }
}

