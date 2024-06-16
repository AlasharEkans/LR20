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
using System.Windows.Markup;

namespace LR24example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));
        }
        Thread thread1;
        Thread thread2;
        Thread thread3;
        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width),
                   rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i => {
                    RichTextBox1.Invoke((MethodInvoker)delegate ()
                    {
                        RichTextBox1.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //draw_eclips();
            //draw_rect();
            //Rnd_num();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Start();
            //draw_rect();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            thread2.Start();
            //draw_eclips();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            thread3.Start();
            //Rnd_num();
        }
        private void button5_Click(object sender, EventArgs e)
        {

            thread1.Suspend();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();
        }
        private void Form1_Formclosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }
    }
}