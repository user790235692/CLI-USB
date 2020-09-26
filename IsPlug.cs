
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
            return  false;
            }

            else
            {
            return false;
            }

        }
    }
        
}