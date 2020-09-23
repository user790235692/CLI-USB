using System;
using System.Collections.Generic;


namespace CSharpSts
{
    public class Usb 
    {

        public int RealCapacityGo {get; set;}

        public ulong RealCapacityBytes {get; set;}

        public override string ToString()
        {
            return "Go: " + RealCapacityGo + "   Byte: " + RealCapacityBytes;
        }

        public void Capacity()
        {
            List<Usb> usb = new List<Usb>();

            usb.Add(new Usb() {RealCapacityGo=4, RealCapacityBytes=4294967296});
            usb.Add(new Usb() {RealCapacityGo=8, RealCapacityBytes=8589934592});
            usb.Add(new Usb() {RealCapacityGo=16, RealCapacityBytes=17179869184});
            usb.Add(new Usb() {RealCapacityGo=32, RealCapacityBytes=34359738368});
            usb.Add(new Usb() {RealCapacityGo=64, RealCapacityBytes=68719476736});
            usb.Add(new Usb() {RealCapacityGo=128, RealCapacityBytes=137438953472});
            usb.Add(new Usb() {RealCapacityGo=256, RealCapacityBytes=274877906944});
            usb.Add(new Usb() {RealCapacityGo=512, RealCapacityBytes=549755813888});

            foreach(Usb usb1 in usb)
            {
                Console.WriteLine(usb1);
            }
        }
    }

}
