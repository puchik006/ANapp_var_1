using System;
using System.Collections.Generic;

namespace ANapp_var_1
{
    public class AppInstaller : IAppInstaller
    {
        public void InstallApp(App app, ref List<App> appList)
        {
            appList.Add(app);
            Console.WriteLine($"You install {app}");
        }
    }

}
