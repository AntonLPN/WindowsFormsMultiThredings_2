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
    public partial class FormTask3cs : Form
    {
        public FormTask3cs()
        {
            InitializeComponent();
        }

       async private void button1_Click(object sender, EventArgs e)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);   //Получить случайное число (в диапазоне от 0 до 10)
            }
            var res = await Task.Run(()=> MethodTask3());
            Task.WaitAll();
            foreach (var item in res)
            {
                textBox1.Text += item.ToString() + "|";
            }
        }

        /// <summary>
        /// метод выводит значения массива
        /// </summary>
        /// <param name="obj"></param>
        private int[] MethodTask3()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);   //Получить случайное число (в диапазоне от 0 до 10)
            }


            return arr;
        }

    }
    }

