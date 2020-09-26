using System;
using System.Collections.Generic;

namespace CSharpSts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer une clé usb !");

            string valueInput = Console.ReadLine();

            try
            {
                FetchUSB(Int32.Parse(valueInput));
            }

            catch(FormatException)
            {
                Console.WriteLine("Rentrez seulement des chiffres !");
            }

            IsPlugIn();

            SaveFile saveFile = new SaveFile();

            saveFile.Main();

            

        }
        public static List<Usb> CreateUSB() {
            List<Usb> usb = new List<Usb>();
            
            usb.Add(new Usb(4, 1073741824));
            usb.Add(new Usb(8, 8589934592));
            usb.Add(new Usb(16, 17179869184));
            usb.Add(new Usb(32, 34359738368));
            usb.Add(new Usb(64, 68719476736));
            usb.Add(new Usb(128, 137438953472));
            usb.Add(new Usb(256, 274877906944));
            usb.Add(new Usb(512, 549755813888));

            return usb;
        }
        public static void FetchUSB(int RealCapacityGo)
        {
            List<Usb> usb_keys = CreateUSB();

            bool IsGood = false;

            foreach(var usb in usb_keys)
            {   
                
                if (usb.RealCapacityGo == RealCapacityGo)
                {
                    IsGood = true;

                    Console.WriteLine($"USB trouvé : {usb}");
                }
            }

            foreach(var usb in usb_keys)
            {
                if (!IsGood)
                {
                Console.WriteLine($"Usb non trouvé, veuillez entrer une capcité valide {usb}");
                }   
            } 
                   
        }

        public static void IsPlugIn()
        {
            IsPlug isPlug = new IsPlug();

            var result = isPlug.getBoolInputValue(Console.ReadLine());

            Console.WriteLine(result);
        }
    }
}

