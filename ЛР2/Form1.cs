using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double x , y, q;
            x= Convert.ToDouble(textBox1.Text);//число
            y= Convert.ToDouble(textBox2.Text);//процент
            q = x / 100 * y;
            label1.Text = Convert.ToString(q);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Vichislenie);
            label8.Text = "Выполняется расчет";
            thread.Start();
        }

        public void Vichislenie(object input)
        {
          for (int i = 0; i < 100;i++)
            {
                Thread.Sleep(100);
            }
            double x, y, q;
            Invoke(new Action(() =>
            {
                x = Convert.ToDouble(textBox3.Text);//число
                y = Convert.ToDouble(textBox4.Text);//число
                q = y * 100 / x;
                label2.Text = Convert.ToString(q);
                

            }));
        }
    }
}
