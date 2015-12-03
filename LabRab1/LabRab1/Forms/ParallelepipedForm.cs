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
    public partial class ParallelepipedForm : Form
    {
        public ParallelepipedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if (textBoxA.Text == "") 
            {
                MessageBox.Show("Поля А пустое", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxB.Text == "") 
            {
                MessageBox.Show("Поля B пустое", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxC.Text == "")
            {
                MessageBox.Show("Поля С пустое", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int a, b, c;
            double V = 0;
            if (int.TryParse(textBoxA.Text, out a)&& (a > 0))
            {
                if (int.TryParse(textBoxB.Text, out b) && (b > 0))
                {
                    if (int.TryParse(textBoxC.Text, out c) && (c > 0))
                    {
                        try
                        {
                            Parallelepiped parallelepiped = new Parallelepiped(a, b, c);
                            V = parallelepiped.ReturnVolume();
                            textBoxV.AppendText(V.ToString());
                        }
                        catch (DivideByZeroException error)
                        {
                            MessageBox.Show("АШИПКА", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в поле C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка в поле В", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ошибка в поле A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
