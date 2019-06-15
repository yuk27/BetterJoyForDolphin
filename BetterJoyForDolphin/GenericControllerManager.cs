using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterJoyForDolphin
{
    class GenericControllerManager
    {
        List<DolphinJoyConfig> joysConfig;

        private const ushort product_l = 0x2006;
        private const ushort product_r = 0x2007;
        private const ushort product_pro = 0x2009;

        //private string leftFile = "LeftSerials.dat";
        //private string rightFile = "rightSerials.dat";

        private string file = "Serials.dat";

        public GenericControllerManager() {

            LoadSerials();

        }

        public void SaveSerials() {
            string[] stringConfig = new string[joysConfig.Count];

            for (int i = 0; i < joysConfig.Count; i++) {
                stringConfig[i] = joysConfig[i].GetConfig();
            }

            SaveJoy(stringConfig, file);
        }

        public void LoadSerials() {
            joysConfig = GetSerials(file);
        }

        public DolphinJoyConfig Contains(string serial) {

            foreach (DolphinJoyConfig config in joysConfig)
            {
                if (config.serial_number == serial)
                {
                    return config;
                }
            }

            DolphinJoyConfig instance = new DolphinJoyConfig();
            instance.SetConfig("-1", 0x2009);
            return instance;
        }

        public void AddSerial(string serial, ushort id, int force = 10, int x = 1, int y = 1, int z = 1) {

            bool found = false;

            for (int i = 0; i < joysConfig.Count; i++) {
                if (joysConfig[i].serial_number == serial) {
                    DolphinJoyConfig config = joysConfig[i];
                    config.SetConfig(serial, id, force, x, y, z);
                    joysConfig[i] = config;
                    found = true;
                    break;
                }
            }

            if (!found) {
                DolphinJoyConfig instance = new DolphinJoyConfig();
                instance.SetConfig(serial,id, force, x,y,z);
                joysConfig.Add(instance);
            }

        }

        public List<DolphinJoyConfig> GetSerials(string filename) {

            List<DolphinJoyConfig> serials = new List<DolphinJoyConfig>();

            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + filename))
            {
                string[] configs = System.IO.File.ReadAllLines(filename);

                foreach (string config in configs)
                {
                    DolphinJoyConfig instance = new DolphinJoyConfig();
                    instance.LoadConfig(config);
                    serials.Add(instance);
                }

            }
            else {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + filename);
            }

            return serials;
        }

        public void SaveJoy(string[] serialsStrings, string filename) {
            string path = AppDomain.CurrentDomain.BaseDirectory + filename;
            System.IO.File.WriteAllLines(path, serialsStrings);
        }
    }
}
