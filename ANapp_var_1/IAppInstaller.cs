using System.Collections.Generic;

namespace ANapp_var_1
{
    public interface IAppInstaller
    {
        void InstallApp(App app, ref List<App> appList);
    }


}
