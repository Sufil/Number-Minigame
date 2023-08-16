using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Minigame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int themeCounter = 0;

        private void Btn_Theme_Click(object sender, EventArgs e)
        {
            themeCounter++;

            switch (themeCounter)
            {
                case 1:
                    {
                        MessageBox.Show("What the fuck is wrong with you", "Error");
                    }
                    break;

                case 2:
                    {
                        MessageBox.Show("No. Stop it. This will not happen.", "Error");
                    }
                    break;

                case 3:
                    {
                        MessageBox.Show("You know what? Fuck you.", "Error");
                        startChaos();
                    }
                    break;
            }
        }

        private void startChaos()
        {
            Btn_Theme.Enabled = false;
            // Still misses the Chaos
        }
    }
}
