using System;
using System.Collections.Generic;


namespace CSharpSts
{
    public class Usb 
    {
        public int RealCapacityGo {get; set;}

        public ulong RealCapacityBytes {get; set;}

        public Usb(int RealCapacityGo, ulong RealCapacityBytes) {
            this.RealCapacityGo = RealCapacityGo;
            this.RealCapacityBytes = RealCapacityBytes;
        }

        public override string ToString()
        {
            return $"Go: {RealCapacityGo}  Byte: {RealCapacityBytes}";
        }
    }

}
