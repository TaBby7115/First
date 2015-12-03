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
    public partial class PyramidForm : Form
    {
        public PyramidForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if (textBoxS.Text == "") 
            {
                MessageBox.Show("Поле площадь основания пустое", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxH.Text == "") 
            {
                MessageBox.Show("Поле высота пирамиды пустое", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int S, H;
            double V;
            //   if ((int.TryParse(textBoxS.Text, out S))
            //     && (int.TryParse(textBoxH.Text, out H))
            //   && ((S > 0) && (H > 0)))
            if (int.TryParse(textBoxS.Text, out S))
            {
                if (S > 0)
                {
                    if (int.TryParse(textBoxH.Text, out H))
                    {
                        if (H > 0)
                        {
                            try
                            {
                                Pyramid pyramid = new Pyramid(S, H);
                                V = pyramid.ReturnVolume();
                                textBoxV.AppendText(V.ToString());
                            }
                           catch (DivideByZeroException error)
                           {
                               MessageBox.Show("АШИПКА", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }
                        }
                        else
                        {
                            MessageBox.Show("Высота введена отрицательной", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле высота введен неправильный символ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    }
                else
                {
                    MessageBox.Show("Площадь введена отрицательной", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                }
            else
            {
                MessageBox.Show("В поле высота неверный символ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }

            
           
        }
  }
