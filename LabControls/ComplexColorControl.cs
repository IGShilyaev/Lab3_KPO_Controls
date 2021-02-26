using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ComplexColorControl : UserControl
    {
        public event EventHandler CurrentColorChanged;

        public ComplexColorControl()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
        }

        public Color CurrentColor 
        {
            get
            { 
                return rectControl1.CurrColor; 
            } 
            set
            {
                switch (colorBox1.CurrentNumSystem)
                {
                    case "Dec":
                        {
                            DecTextSetup(value);
                            break;
                        }
                    case "Hex":
                        {
                            HexTextSetup(value);
                            break;
                        }
                }
            }
             }

        private void colorBox1_CurrentNumSystemChanged(object sender, EventArgs e)
        {
            //List<ColorBox> cdList = new List<ColorBox> { colorBox1, colorBox2, colorBox3 };
            //foreach (ColorBox cb in cdList)
            //{
            //    if (cb.CurrentNumSystem == "Dec") cb.Text = Convert.ToInt32(cb.Text, 16).ToString();
            //    else cb.Text = Convert.ToString(int.Parse(cb.Text), 16).ToUpper();
            //}
        }

        private void DecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DecRadioButton.Checked == true) 
            { 
                colorBox1.CurrentNumSystem = "Dec";
                colorBox2.CurrentNumSystem = "Dec";
                colorBox3.CurrentNumSystem = "Dec";
            }
            else
            {
                colorBox1.CurrentNumSystem = "Hex";
                colorBox2.CurrentNumSystem = "Hex";
                colorBox3.CurrentNumSystem = "Hex";
            }
            BaseConvert();
        }

        private void colorBox1_TextChanged(object sender, EventArgs e)
        {
            ColorBox cb = (ColorBox)sender;
            switch (cb.CurrentNumSystem)
            {
                case "Dec":
                    {
                        DecColorChange();
                        break;
                    }
                case "Hex":
                    {
                        HexColorChange();
                        break;
                    }
            }
            rectControl1.Invalidate();
        }

        private void DecColorChange()
        {
            try
            {
                rectControl1.CurrColor = Color.FromArgb(int.Parse(colorBox1.Text),
                    int.Parse(colorBox2.Text), int.Parse(colorBox3.Text));
                OnCurrentColorChanged();
            }
            catch
            {
                return;
            }
        }

        private void HexColorChange()
        {
            try
            {
                rectControl1.CurrColor = Color.FromArgb(Convert.ToInt32(colorBox1.Text, 16),
                    Convert.ToInt32(colorBox2.Text, 16), Convert.ToInt32(colorBox3.Text, 16));
                OnCurrentColorChanged();
            }
            catch
            {
                return;
            }
        }

        protected void OnCurrentColorChanged()
        {
            if (CurrentColorChanged != null)
                CurrentColorChanged(this, new EventArgs());
        }

        private void BaseConvert()
        {
            List<ColorBox> cdList = new List<ColorBox> { colorBox1, colorBox2, colorBox3 };
            foreach (ColorBox cb in cdList)
            {
                if (cb.CurrentNumSystem == "Dec") cb.Text = Convert.ToInt32(cb.Text, 16).ToString();
                else cb.Text = Convert.ToString(int.Parse(cb.Text), 16).ToUpper();
            }
        }

        private void DecTextSetup(Color c)
        {
            colorBox1.Text = c.R.ToString();
            colorBox2.Text = c.G.ToString();
            colorBox3.Text = c.B.ToString();
        }

        private void HexTextSetup(Color c)
        {
            colorBox1.Text = Convert.ToString(int.Parse(c.R.ToString()), 16);
            colorBox2.Text = Convert.ToString(int.Parse(c.G.ToString()), 16);
            colorBox3.Text = Convert.ToString(int.Parse(c.B.ToString()), 16);
        }
    }
}
