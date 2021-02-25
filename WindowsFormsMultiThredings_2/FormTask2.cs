using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMultiThredings_2
{
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }


          private int[] MethodShowFor()
        {
            int[] arr=new int[51];


            for (int i = 0; i <= 50; i++)
            {
                arr[i] = i;
            }
            return arr;

        }


      
       async private void button1_Click(object sender, EventArgs e)
        {

            var result = await Task.Run(() => MethodShowFor());
            Task.WaitAll();
            foreach (var item in result)
            {
                textBox1.Text += item.ToString() + "|";
            }


        }
    }
}
