namespace ANapp_var_1
{
    public class App 
    {
        private string _appName;
        
        public App(string appName)
        {
            _appName = appName;
        }

        public override string ToString()
        {
            return _appName;
        }
    }
}
