using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class RectControl : Control
    {
       

        public Color CurrColor
        {
            get; set;  
        }

        public RectControl()
        {
            CurrColor = Color.Black;
            InitializeComponent();
        }

        public RectControl(IContainer container)
        {
            container.Add(this);
            CurrColor = Color.Black;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            e.Graphics.FillRectangle(new SolidBrush(CurrColor), ClientRectangle);
        }
    }
}
