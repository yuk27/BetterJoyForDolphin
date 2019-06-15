using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterJoyForDolphin
{
    struct DolphinJoyConfig
    {
        public string serial_number;
        public int force;
        public int[] inverse;
        public ushort product_id;

        public void LoadConfig(string input) {

            string[] config = input.Split('|');

            SetConfig(config[0], ushort.Parse(config[1]), int.Parse(config[2]), int.Parse(config[3]), int.Parse(config[4]), int.Parse(config[5]));

        }

        public void SetConfig(string serial, ushort id, int force = 10, int x = 1, int y = 1, int z = 1) {

            serial_number = serial;
            product_id = id;
            this.force = force;
            inverse = new int[]{x,y,z};

        }

        public string GetConfig() {

            return serial_number + "|" + product_id + "|" + force + "|" + inverse[0] + "|" + inverse[1] + "|" + inverse[2];

        }


    }
}
