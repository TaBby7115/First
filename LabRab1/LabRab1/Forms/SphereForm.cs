using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    public partial class SphereForm : Form
    {
        public SphereForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if (textBoxR.Text == "")
            {
                MessageBox.Show("Поля пусты.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int R;
            double V = 0;
            if ((int.TryParse(textBoxR.Text, out R)))
            {
                if (R > 0)
                {
                    try
                    {
                        Sphere sphere = new Sphere(R);
                        V = sphere.ReturnVolume();
                        textBoxV.AppendText(V.ToString());
                    }
                    catch (DivideByZeroException error)
                    {
                        MessageBox.Show("АШИПКА", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                else
                {
                    MessageBox.Show("Значения полей должны быть больше нуля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Были введены недопустимые символы.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
