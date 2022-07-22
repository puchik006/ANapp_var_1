using System.Collections.Generic;

namespace ANapp_var_1
{
    public class PC : IMetallCollectable, ISellable
    {
        public int Price => _price; 
        public int MetallMass => _metallMass; 

        private bool _isOn;
        private string _pcName;
        private int _price = 500;
        private int _metallMass = 123;

        private List<App> _appList = new List<App>(); 

        private SparePart _motherBoard = new SparePart("old motherboard", 12345); 

        private IReset _reset;
        private ISwitch _switch;
        private IPartChanger _partChanger;
        private IAppInstaller _appInstaller;

        public PC(string pcName, IReset reset, ISwitch pcSwitch, IPartChanger partChange, IAppInstaller appInstaller)
        {
            _pcName = pcName;
            _reset = reset;
            _switch = pcSwitch;
            _partChanger = partChange;
            _appInstaller = appInstaller;
        }

        /// <summary>
        /// Перезагружает компьютер
        /// </summary>
        public void Reset() => _reset.ResetPC(this);
        
        /// <summary>
        /// Изменяет статус компьютера вкл/выкл
        /// </summary>
        public void Switch() => _switch.SwithcOnOffPC(ref _isOn);

        /// <summary>
        /// Меняет материнскую плату компьютера на новую, которая передаётся в качестве аргумента метода
        /// </summary>
        public void ChangePart(SparePart newSparePart) => _partChanger.ChangeSparePartInPC(newSparePart, ref _motherBoard);

        /// <summary>
        /// Добавляет приложение в коллекцию приложений
        /// </summary>
        public void InstallApp(App app) => _appInstaller.InstallApp(app, ref _appList);
 
        public override string ToString() => _pcName;
    }
}
