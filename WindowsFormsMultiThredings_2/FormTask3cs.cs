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

//Задание №3
//Переведите четвертое задание Лабораторной работы №3 со всеми
//изменениями в оконный интерфейс.
namespace WindowsFormsMultiThredings_2
{
    public partial class FormTask3cs : Form
    {
        int[] arr;
        public FormTask3cs()
        {
            InitializeComponent();
            arr = new int[10];
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------
            //                        Задание №4
            //Консольное приложение генерирует набор чисел, состоящий из 10000
            //элементов.С помощью механизма потоков нужно найти максимум, минимум,
            //среднее в этом наборе.
            //Для каждой из задач выделите поток.

            //не разобрался с invoke поэтому сделал тасками

            var min =await Task.Run(() =>MinArr().ToString());
            var max = await Task.Run(() => MaxArr().ToString()) ;
            var avr = await Task.Run(() => AverageArr().ToString());
            Task.WaitAll();

            textBoxMin.Text = min;
            textBoxMax.Text = max;
            textBoxAverage.Text = avr;





        }





        private int  MinArr()
        {

           var res = arr.Min();
            return res;
        }
        private int MaxArr()
        {
            var res = arr.Max();
            return res;
        }

        private double AverageArr()
        {
            var res = arr.Average();
            return res;
        }

        private void FormTask3cs_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10000);   //Получить случайное число (в диапазоне от 0 до 10000)
            }
           

            for (int i = 0; i < arr.Length; i++)
            {
                this.textBoxArrValue.Text += arr[i].ToString() + "|";
            }
        }
    }
    }

