using System;
using System.Threading;
using System.Windows.Forms;

namespace WF_Threads_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            Thread th = new Thread(MegaTaskStart);
            th.Start();

            //MegaTaskStart();

            button1.Enabled = true;
            button2.Enabled = true;


        }

        private void MegaTaskStart()
        {
            Thread.Sleep(5000);
            MessageBox.Show("My MegaTask Ended!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
