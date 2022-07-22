//Выделил включение, перезагрузку, замену платы и установку приложения как поведения реализуемые внутри объека компьютер (PC)
//Для каждой сделал абстракцию в виде интрефейсов и реализовал их
//Продажа компьюткра и сбор металлолома реализовал как действия совершаемые с объектом компьютер

using System;

namespace ANapp_var_1
{
    class Program
    {
        private const string CASE =
            "1.Включение/перезагрузка компьютера. \r\n" +
            "2.Установка пользовательского приложения в компьютерном классе. \r\n" +
            "3.Продажа компьютеров. \r\n" +
            "4.Замена материнской платы. \r\n" +
            "5.Сборметаллолома";

        private static PC pc1 = new PC("PC 1", new Reset(), new Switch(),new PartChanger(), new AppInstaller());

        private static SparePart motherBoard = new SparePart("new motherboard", 54321);

        private static Customer customer = new Customer();

        private static App app1 = new App("app1");

        static void Main(string[] args)
        {
            Console.WriteLine(CASE);
            Console.WriteLine();
            pc1.Switch();
            pc1.Switch();
            pc1.Reset();

            Console.WriteLine();
            pc1.InstallApp(app1);

            Console.WriteLine();
            customer.Purchase(pc1);

            Console.WriteLine();
            pc1.ChangePart(motherBoard);

            Console.WriteLine();
            customer.CollectMetall(pc1);
        }
    }
}
