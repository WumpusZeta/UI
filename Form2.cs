using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form2 : Form
    {

        DisplayUI myui;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myui = new DisplayUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = myui.DisplayHS().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
