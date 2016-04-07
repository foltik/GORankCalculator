using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORankCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool doAdd = true;
            int intXP;
            if (!Int32.TryParse(boxXP.Text, out intXP))
            {
                MessageBox.Show("Invalid Character.");
            }


            int intCur;
            if (!Int32.TryParse(boxCur.Text, out intCur))
            {
                MessageBox.Show("Invalid Character.");
            }


            int intRank;
            if (!Int32.TryParse(boxRank.Text, out intRank))
            {
                MessageBox.Show("Invalid Character.");
            }


            int intAdd;
            if (!Int32.TryParse(boxAdd.Text, out intAdd))
            {
                doAdd = false;
            }

            if (doAdd == true) {
                intXP += intAdd;
                boxXP.Text = intXP.ToString();
            }

            int intXPF = (5000*(intRank-intCur)) - intXP;
            int intDMF = intXPF / 120;
            float intTMF = (intDMF * 10)/60;

            ProjDM.Text = intDMF.ToString();
            ProjXP.Text = intXPF.ToString();
            ProjTime.Text = intTMF.ToString();

        }
    }
}
