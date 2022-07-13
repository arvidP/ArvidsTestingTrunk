using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "0";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int addOne = Int32.Parse(lblHelloWorld.Text)+1;
            lblHelloWorld.Text = addOne.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int minOne = Int32.Parse(lblHelloWorld.Text) - 1;
            lblHelloWorld.Text = minOne.ToString();
        }
    }
}
