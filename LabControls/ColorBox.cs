using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{

    public partial class ColorBox : TextBox
    {

        public event EventHandler CurrentNumSystemChanged;

        public string CurrentNumSystem { get; set; }
        public ColorBox()
        {
            InitializeComponent();
            CurrentNumSystem = "Dec";
            Text = "0";
        }

        public ColorBox(IContainer container)
        {
            container.Add(this);
            CurrentNumSystem = "Dec";
            Text = "0";
            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            switch (CurrentNumSystem)
            {
                case "Dec":
                    {
                        DecTextChange();
                        break;
                    }
                case "Hex":
                    {
                        HexTextChange();
                        break;
                    }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (CurrentNumSystem)
            {
                case "Dec":
                    {
                        DecKeyHandle(e);
                        break;
                    }
                case "Hex":
                    {
                        HexKeyHandle(e);
                        break;
                    }
            }

        }

        private void DecTextChange()
        {
            if (Text == "") Text = "0";
            if (Convert.ToInt32(Text) < 0) Text = "0";
            else if (Convert.ToInt32(Text) > 255) Text = "255";
        }

        private void HexTextChange()
        {
            if (Text == "") Text = "0";
            if (Convert.ToInt32(Text,16) < 0) Text = "0";
            else if (Convert.ToInt32(Text,16) > 255) Text = "FF";
        }

        private void DecKeyHandle(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void HexKeyHandle(KeyPressEventArgs e)
        {
            char[] symbs = {
                'A', 'B', 'C', 'D', 'E', 'F' };
            char[] chngSymbs = {
                'a', 'b', 'c', 'd', 'e', 'f' };
            for(int i = 0; i < chngSymbs.Length; i++)
            {
                if (chngSymbs[i] == e.KeyChar) e.KeyChar = symbs[i];
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && !symbs.Contains(e.KeyChar))
                e.Handled = true;

        }
        protected void OnCurrentNumSystemChanged()
        {
            if (CurrentNumSystemChanged != null)
                CurrentNumSystemChanged(this, new EventArgs());
        }



    }
}
