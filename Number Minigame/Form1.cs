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
        int rows = 10;
        int columns = 10;
        
        List<List<int>> NumbersVertikal = new List<List<int>>();

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

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            bool ComputerPlays;

            if (RBtn_Normal.Checked)
            {
                ComputerPlays = false;
            }
            else
            {
                ComputerPlays = true;
            }

            startGame(ComputerPlays);
        }

        private void startGame(bool solve)
        {
            generateNumbers();
            showNumbers();
        }

        private void generateNumbers()
        {
            Random numbers = new Random();

            // Create Number field
            for (int i = 0; i < rows; i++)
            {
                List<int> NumbersHorizontal = new List<int>();

                for (int j = 0; j < columns; j++)
                {
                    NumbersHorizontal.Add(numbers.Next(0,10));
                }

                NumbersVertikal.Add(NumbersHorizontal);
            }

            // Create Numbers to search for
        }

        private void showNumbers()
        {
            for (int y = 0; y < columns; y++)
            {
                List<int> NumbersForRow = NumbersVertikal[y];

                for (int x = 0; x < rows; x++)
                {
                    Button Btn_Number = new Button();

                    // Wie im Designer, erschaffen von Buttons
                    // (So erschaffen, damit nicht jeder einzelne Button einzeln erstellt/abgefragt werden muss)
                    Btn_Number.Location = new Point(500 + x * 30, 100 + y * 30);
                    Btn_Number.Name = "Btn_Card";
                    Btn_Number.Size = new Size(30, 30);
                    Btn_Number.TabIndex = 1;
                    Btn_Number.Cursor = Cursors.Hand;
                    Btn_Number.UseVisualStyleBackColor = true;
                    Btn_Number.Font = new Font("Microsoft Sans Serif", 16F);

                    Btn_Number.Text = NumbersForRow[x].ToString();

                    this.Controls.Add(Btn_Number);
                }
            }

        }

        private void CB_Colours_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Colours.Checked)
            {
                GB_Colours.Visible = true;
            }
            else
            {
                GB_Colours.Visible = false;
            }
        }

        private void Btn_Rules_Click(object sender, EventArgs e)
        {


        }
    }
}
