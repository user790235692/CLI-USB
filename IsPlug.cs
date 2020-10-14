using System;

namespace CSharpSts
{
    public class IsPlug
    {
        public bool getBoolInputValue(string intputType)
        {
           
            if (intputType.ToLower() == "yes")
            {
            return true;
            }

            else if (intputType.ToLower() == "no")
            {
            Environment.Exit(1);
            return  false;
            }

            else
            {
            Environment.Exit(1);
            return false;
            }

        }
    }
        
}