using System;
using System.IO;
using System.Configuration;
using System.Xml;
using Microsoft.Extensions.Configuration;
using System.Resources;
using System.Reflection;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var FileMap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

            //вывод сообщение из файла resurces.resx
            Console.WriteLine(task.Properties.Resources.HelloWord);
            ResourceManager rm = new ResourceManager(baseName:"task.DataStrings", Assembly.GetExecutingAssembly());


            //проверка на существовнаие файла конфигурации
            if (File.Exists(FileMap.ExeConfigFilename))
            {
                Console.WriteLine(config.AppSettings.Settings["UserName"].Value);
                Console.WriteLine(config.AppSettings.Settings["Age"].Value);
                Console.WriteLine(config.AppSettings.Settings["Profession"].Value);
            }else
            {
                Console.WriteLine("Hello User! Данные о вас не занесены в файл конфигурации");

                Console.WriteLine("Введите свое имя");
                string Name = Console.ReadLine();
                Console.WriteLine("{0} введите свой возраст", Name);
                string Age = Console.ReadLine();
                Console.WriteLine("{0} чем вы занимаетесь?", Name);
                string Profession = Console.ReadLine();

                config.AppSettings.Settings.Add("UserName", Name);
                config.AppSettings.Settings.Add("Age", Age);
                config.AppSettings.Settings.Add("Profession", Profession);

                config.Save();
            }
        }
    }
}
