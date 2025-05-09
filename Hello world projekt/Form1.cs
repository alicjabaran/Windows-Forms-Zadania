using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_world_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }

        private void guzik_Click(object sender, EventArgs e)
        {
            Hello.Text = "Hello World";
        }
    }
}
