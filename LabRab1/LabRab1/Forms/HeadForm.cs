using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }
        
        private void buttonSphere_Click(object sender, EventArgs e)
        {
            SphereForm windowSphere = new SphereForm();
            windowSphere.Show();
        }

        private void buttonPiram_Click(object sender, EventArgs e)
        {
            PyramidForm windowPiram = new PyramidForm();
            windowPiram.Show();
        }

        private void buttonParall_Click(object sender, EventArgs e)
        {
            ParallelepipedForm windowParall = new ParallelepipedForm();
            windowParall.Show();
        }
    }
}
