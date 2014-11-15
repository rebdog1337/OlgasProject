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
    public partial class Pre1stBoard : Form
    {
        public Pre1stBoard()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Drawing_1 newBoard = new Drawing_1();
            newBoard.ShowDialog();
        }
    }
}
