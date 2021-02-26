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
    public partial class FilePathSelect : UserControl
    {
        public FilePathSelect()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return pathTextBox.Text;
            }
            set
            {
                pathTextBox.Text = value;
            }

        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            FileName = ofd.FileName;
        }
    }
}
