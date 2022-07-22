using System;

namespace ANapp_var_1
{
    public class Switch : ISwitch
    {
        public void SwithcOnOffPC(ref bool isOn)
        {
            isOn = !isOn;

            string pcState = isOn ? "switched On" : "switched Off";

            Console.WriteLine($"Computer is {pcState}");
        }
    }


}
