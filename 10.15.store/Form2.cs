using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._15.store
{
    public partial class Form2 : Form
    {
        public string GetwName()
        {
            if (textBox1.Text == null)
            {
                return "";
            }
            else
            {
                return textBox1.Text;
            }
        }

        public string GetwDescription()
        {
            if (textBox2.Text == null)
            {
                return "";
            }
            else
            {
                return textBox2.Text;
            }
        }

        public string GetwCharacteristics()
        {
            if (textBox3.Text == null)
            {
                return "";
            }
            else
            {
                return textBox3.Text;
            }
        }

        public double GetwPrice()
        {
            if (textBox4.Text == "")
            {
                return 0;
            }
            else
            {
                try
                {
                    return Convert.ToDouble(textBox4.Text);
                }
                catch (System.FormatException)
                {
                    return 0;
                }
            }
        }

        public Form2()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
