using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    public partial class PreviewControl : UserControl
    {
        public PreviewControl()
        {
            InitializeComponent();
        }

        private void openPDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFilePDFDialog.ShowDialog () == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = openFilePDFDialog.FileName;
            }
        }
    }
}
