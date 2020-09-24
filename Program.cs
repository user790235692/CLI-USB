using System;
using System.Collections.Generic;

namespace CSharpSts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valueInput = Console.ReadLine();
            FetchUSB(Int32.Parse(valueInput));
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

            foreach(var usb in usb_keys)
            {
                if (usb.RealCapacityGo == RealCapacityGo)
                    Console.WriteLine($"USB trouvé : {usb}");
            }   
        }
    }

}