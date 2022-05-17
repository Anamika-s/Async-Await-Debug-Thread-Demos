using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnCallFunction_Click(object sender, EventArgs e)
        //{
        //    lblText.Text = "Processing File .... ";
        //    int count = CountCharacters();
        //    lblText.Text += count.ToString();
        //}
        private async void btnCallFunction_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lblText.Text = "Processing File .... ";
            int count =  await task;
            lblText.Text += count.ToString();
        }
        int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"E:\data\data.txt"))
            {
                string data = reader.ReadToEnd();
                count = data.ToString().Length;
                Thread.Sleep(5000);
            }
            return count;
        }
    }
}
