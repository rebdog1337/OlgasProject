using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Sign_Off_Sheet
{
    public partial class Drawing_1 : Form
    {
        public Drawing_1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Drawing_2 newBoard = new Drawing_2();
            newBoard.ShowDialog();
        }
    }
}
