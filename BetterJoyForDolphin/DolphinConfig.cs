using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterJoyForDolphin
{
    public partial class DolphinConfig : Form
    {
        private Joycon joy;
        private ushort id = 0x2009;
        int typeChanged;

        public DolphinConfig(Joycon joy = null)
        {
            typeChanged = 0;
            this.joy = joy;
            InitializeComponent();
            sensibilityBar.Value = joy.GetPack().GetForce();

            if (!joy.isPro && joy.isLeft)
            {
                LeftRadio.Checked = true;
            }
            else if (!joy.isPro && !joy.isLeft)
            {
                RightRadio.Checked = true;
            }
            else {
                ProRadio.Checked = true;
            }

            int[] inverted = joy.GetPack().GetInverted();

            checkBoxX.Checked = inverted[0] < 1 ? true:false;
            checkBoxY.Checked = inverted[1] < 1 ? true : false;
            checkBoxZ.Checked = inverted[2] < 1 ? true : false;

            serialNumberLabel.Text = joy.serial_number;
        }

        // Apply btn is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            int z = 1;

            if (checkBoxX.Checked) {
                x = -1;
            }

            if (checkBoxY.Checked)
            {
                y = -1;
            }

            if (checkBoxZ.Checked)
            {
                z = -1;
            }

            joy.GetPack().SetForce(sensibilityBar.Value);
            joy.GetPack().SetInverted(x, y, z);
            Program.generic_manager.AddSerial(joy.serial_number, id, force: sensibilityBar.Value,x:x,y:y,z:z);
            Program.generic_manager.SaveSerials();
            this.Close();
            if (typeChanged > 1)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        // Default Btn is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            sensibilityBar.Value = 10;
            checkBoxX.Checked = false;
            checkBoxY.Checked = false;
            checkBoxZ.Checked = false;
            ProRadio.Checked = true;

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ProRadio.Checked) {
                con1.BackgroundImage = Properties.Resources.pro;
                id = 0x2009;
                typeChanged++;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (LeftRadio.Checked)
            {
                con1.BackgroundImage = Properties.Resources.jc_left;
                id = 0x2006;
                typeChanged++;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RightRadio.Checked)
            {
                con1.BackgroundImage = Properties.Resources.jc_right;
                id = 0x2007;
                typeChanged++;
            }
        }

        private void DolphinConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
