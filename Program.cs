using System;
using System.Collections.Generic;

namespace CSharpSts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IsPlugIn();

            Usb usb = null;

            List<Usb> usb_keys = CreateUSB();

            while (usb == null) {
                Console.WriteLine("Veuillez indiqué l'espace de votre clé usb !");

                try {
                    int valueInputGo = Int32.Parse(Console.ReadLine());
                    usb = FetchUSB(usb_keys, valueInputGo);

                    if (usb == null)
                        Console.WriteLine($"Pas d'USB trouvée, veuillez insérer une de ces valeurs : \n {String.Join("\n", usb_keys)}");
                         
                    else
                        Console.WriteLine($"USB trouvée : {usb}");
                        
                }

                catch(FormatException) {
                    Console.WriteLine("Rentrez seulement des chiffres !");
                }
                
            }

            UsbFileSystem usbFileSystem = null;

            List<UsbFileSystem> usb_format = InitializeUsb();

            while(usbFileSystem == null) {

                Console.WriteLine("Dans quel format vouslez-vous la formater ?");

                try{
                    string valueInputSystem = Console.ReadLine().ToUpper();

                    usbFileSystem = FormatUsb(usb_format, valueInputSystem);

                    if (usbFileSystem == null)
                    {
                        Console.WriteLine($"Pas de format valide voici les disponibles : \n {usb_format}");
                    }

                    else
                        Console.WriteLine($"La clé usb est formaté en : {usb_format}");
                }
                catch(FormatException){
                    Console.WriteLine("Rentrez seulement des caratères !");

                }

            }
              
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
        public static Usb FetchUSB(List<Usb> usb_keys, int RealCapacityGo)
        {
            List<Usb> result = usb_keys.FindAll(usb => usb.RealCapacityGo == RealCapacityGo);
            
            if (result.Count == 1)
                return result[0];
            
            else
                return null;
        }

        public static List<UsbFileSystem> InitializeUsb()
        {
            List<UsbFileSystem> usbFileSystem = new List<UsbFileSystem>();

            usbFileSystem.Add(new UsbFileSystem ("NTFS"));
            usbFileSystem.Add(new UsbFileSystem ("FAT32"));
            usbFileSystem.Add(new UsbFileSystem ("EXFAT"));

            return usbFileSystem;
        }

        public static UsbFileSystem FormatUsb(List<UsbFileSystem> usb_format, string FileSytem)
        {
            List<UsbFileSystem> result =  usb_format.FindAll(usbFileSystem => usbFileSystem.FileSystem == FileSytem);

            if(result.Count == 1)
            {
                return result[0];
            }

            else
                return null;

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

