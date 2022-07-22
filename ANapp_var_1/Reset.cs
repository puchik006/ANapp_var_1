using System;

namespace ANapp_var_1
{
    public class Reset : IReset
    {
        public void ResetPC(PC pc)
        {
            Console.WriteLine($"Computer {pc} is reset");
        }
    }


}
