using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Process[] processes;
        Process proc = new Process();

        private void GetProcesses()
        {
            processes = Process.GetProcesses();

            listBox_Proc.Items.Clear();

            for(int i = 0; i < processes.Length; i++)
            {
                listBox_Proc.Items.Add(processes[i]);
            }
            listBox_Proc.DisplayMember = "ProcessName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            (listBox_Proc.SelectedItem as Process).Kill();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            listBox_Proc.Sorted = true;
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            proc.StartInfo.FileName = textBox_EXE.Text;
            proc.StartInfo.Arguments = "";
            proc.Start();
        }
    }
}
