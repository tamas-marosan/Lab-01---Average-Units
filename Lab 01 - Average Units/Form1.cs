using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01___Average_Units
{
    public partial class Form1 : Form
    {
        const int NUMBER_OF_DAYS = 7;
        double[] dblUnits = new double[NUMBER_OF_DAYS];
        int currentDay = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtUnits.Text, out dblUnits[currentDay]))
            {
                lblOutput.Text = "Input must be numeric!";
                txtUnits.Text = "";
                txtUnits.Focus();
            }
            else if (dblUnits[currentDay] <= 0)
            {
                lblOutput.Text = "Value must be more than 0!";
                txtUnits.Text = "";
                txtUnits.Focus();
            }
            else
            {
                lblDayUnits.Text += $"{dblUnits[currentDay]}\n";
                currentDay++;
                if (currentDay == 7)
                {
                    lblOutput.Text = $"Average vehicles: ";
                    btnEnter.Enabled = false;
                    txtUnits.ReadOnly = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
