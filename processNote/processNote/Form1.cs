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
using System.Threading;

namespace processNote
{
    public partial class Form1 : Form
    {
        DataHandling data = DataHandling.Instance;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?\r\nAll your comments will be lost!", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processList = data.ProcessList;
            List<string> processNames = new List<string>();

            foreach (Process p in processList)
            {
                processNames.Add(p.ProcessName);
            }
            listBox1.DataSource = processNames;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process[] processList = data.ProcessList;
            int selectedIndex = listBox1.SelectedIndex;
            data.SelectedIndex = selectedIndex;
            Process thisProcess = processList[selectedIndex];
            string processName = thisProcess.ProcessName;
            int ID = thisProcess.Id;
         
            var cpu = new PerformanceCounter("Process", "% Processor Time", processName, true);
            var ram = new PerformanceCounter("Process", "Private Bytes", processName, true);

            cpu.NextValue();
            ram.NextValue();
            Thread.Sleep(300);

            double CPU = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2);
            double RAM = Math.Round(ram.NextValue() / 1024 / 1024, 2);
            string comment;

            if (data.ContainsID(ID))
            {
                comment = data.Get(ID);
            } else
            {
                comment = "no comment added yet";
            }

            try
            {
                DateTime startTime = thisProcess.StartTime;
                TimeSpan runningTime = DateTime.Now - thisProcess.StartTime;
                textBox1.Text = $"name: {processName}\r\nID: {ID}\r\nstarted at: {startTime}\r\ntotal run time: {runningTime}\r\nCPU usage: {CPU}%\r\nRAM usage: {RAM}MB\r\n\r\nComment: {comment}";
            }
            catch (Win32Exception)
            {
                string startTime = "undefined";
                string runningTime = "undefined";
                textBox1.Text = $"name: {processName}\r\nID: {ID}\r\nstarted at: {startTime}\r\ntotal run time: {runningTime}\r\nCPU usage: {CPU}%\r\nRAM usage: {RAM}MB\r\n\r\nComment: {comment}";
            }                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            var form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
