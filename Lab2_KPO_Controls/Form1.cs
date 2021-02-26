using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_KPO_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LableNewColor();
        }

        private void complexColorControl1_CurrentColorChanged(object sender, EventArgs e)
        {
            LableNewColor();
        }

        private void LableNewColor()
        {
            label1.ForeColor = complexColorControl1.CurrentColor;
        }
    }
}
