using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMultiThredings_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            FormTask2 formTask2 = new FormTask2();
            formTask2.ShowDialog();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            FormTask3cs formTask3Cs = new FormTask3cs();
            formTask3Cs.ShowDialog();
            
        }
    }
}
