using System;

namespace ANapp_var_1
{
    public class PartChanger : IPartChanger
    {
        public void ChangeSparePartInPC(SparePart newSparePart, ref SparePart oldSparePart)
        {
            (newSparePart, oldSparePart) = (oldSparePart,newSparePart);
            Console.WriteLine(oldSparePart + " was changed by " + newSparePart);
        }
    }


}
